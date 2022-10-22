
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

        if (p_oid == null)
                throw new Exception ("Ning�n pedido proporcionado");

        if (ped1.ReadOID (p_oid) == null)
                throw new Exception ("El pedido " + p_oid + " no existe");

        PedidoEN pedEN = ped1.ReadOID (p_oid);
        LineaPedidoCEN lin1 = new LineaPedidoCEN ();
        IList<LineaPedidoEN> listalienas = lin1.VerLineasPorPedido (p_oid);
        int x = 1;
        int total = 0;
        int aux = 0;
        if (pedEN.Estado == Enumerated.UltrAthletics.EstadoPedidoEnum.carrito) {
                Console.WriteLine ("Lineas del pedido ");
                foreach (LineaPedidoEN lon in listalienas) {
                        Console.WriteLine ("Linea " + x + " " + lon.Id + " " + lon.Pedido.Id);
                        // SI PONES PRODUCTO PETA  aux= (int)(lon.Producto.Precio * lon.Unidades);
                        Console.WriteLine ("Precio de" + lon.Unidades + " " + lon.Producto.Precio + " " + aux);
                        x++;
                        total += aux;
                }
        }
        else{
                Console.WriteLine ("Lineas del pedido ");
                foreach (LineaPedidoEN lon in listalienas) {
                        Console.WriteLine ("Linea " + x + " " + lon.Id + " " + lon.Pedido.Id);
                        aux = (int)(lon.Precio * lon.Unidades);
                        Console.WriteLine ("Precio de " + lon.Unidades + " unidades de producto: " + aux);
                        x++;
                        total += aux;
                }
        }
        Console.WriteLine ("*******************************************");
        Console.WriteLine ("Precio total " + total);

        return total;

        if (p_oid == null)
                throw new NotImplementedException ("Method GetTotal() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
