
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_getTotal) ENABLED START*/
//  references to other libraries
using UltrAthleticsGenNHibernate.Enumerated.UltrAthletics;
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class PedidoCEN
{
public float GetTotal (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_getTotal) ENABLED START*/
        // Write here your custom code...
        PedidoCEN ped1 = new PedidoCEN ();

        //PRECONDICIONES
        if (ped1.DamePedidoOID (p_oid) == null) {
                throw new Exception ("El pedido " + p_oid + " no existe");
        }

        PedidoEN pedEN = ped1.DamePedidoOID (p_oid);

        LineaPedidoCEN lin1 = new LineaPedidoCEN ();
        IList<LineaPedidoEN> listalienas = lin1.VerLineasPorPedido (p_oid);

        ProductoCEN proAux = new ProductoCEN ();
        ProductoEN proEN = new ProductoEN ();

        int x = 1;
        float total = 0;
        float aux = 0;

        Console.WriteLine ("Lineas del pedido " + p_oid);
        foreach (LineaPedidoEN lon in listalienas) {
                proEN = proAux.DameProductoOID (lon.Producto.Id);
                Console.WriteLine ("Linea " + x + " " + lon.Id + " Del pedido : " + lon.Pedido.Id);
                aux = lin1.GetTotalLinea (lon.Id);
                x++;
                total += aux;
        }

        Console.WriteLine ("******");
        Console.WriteLine ("Precio total " + total);

        return total;
        /*PROTECTED REGION END*/
}
}
}
