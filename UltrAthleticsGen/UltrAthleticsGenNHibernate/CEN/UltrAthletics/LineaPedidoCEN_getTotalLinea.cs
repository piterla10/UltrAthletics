
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UltrAthleticsGenNHibernate.Exceptions;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_LineaPedido_getTotalLinea) ENABLED START*/
//  references to other libraries
using UltrAthleticsGenNHibernate.Enumerated.UltrAthletics;
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class LineaPedidoCEN
{
public float GetTotalLinea (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_LineaPedido_getTotalLinea) ENABLED START*/

        // Write here your custom code...
        LineaPedidoCEN lin1 = new LineaPedidoCEN ();

        //PRECONDICIONES

        if (p_oid == 0)
                throw new Exception ("Ninguna linea proporcionado");

        if (lin1.DameLineaPedidoOID (p_oid) == null)
                throw new Exception ("La  linea de pedido " + p_oid + " no existe");


        LineaPedidoEN linEN = lin1.DameLineaPedidoOID (p_oid);

        PedidoCEN pedCEN = new PedidoCEN ();
        PedidoEN pedEN = pedCEN.DamePedidoOID (linEN.Pedido.Id);

        ProductoCEN proAux = new ProductoCEN ();
        ProductoEN proEN = new ProductoEN ();

        proEN = proAux.DameProductoOID (linEN.Producto.Id);

        float total = 0;

        if (pedEN.Estado == EstadoPedidoEnum.carrito) {
                total = linEN.Unidades * proEN.Precio;
        }
        else{
                total = linEN.Unidades * linEN.Precio;
        }

        Console.WriteLine (linEN.Unidades + " de " + proEN.Nombre + " EL precio total de la linea es: " + total);


        if (total == 0)
                throw new NotImplementedException ("Method GetTotalLinea() not yet implemented.");

        return total;


        /*PROTECTED REGION END*/
}
}
}
