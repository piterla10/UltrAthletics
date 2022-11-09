
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;
using UltrAthleticsGenNHibernate.CEN.UltrAthletics;



/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CP.UltrAthletics_LineaPedido_getTotalLinea) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CP.UltrAthletics
{
public partial class LineaPedidoCP : BasicCP
{
public float GetTotalLinea (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CP.UltrAthletics_LineaPedido_getTotalLinea) ENABLED START*/

        ILineaPedidoCAD lineaPedidoCAD = null;
        LineaPedidoCEN lin1 = null;

        float total = 0;


        try
        {
                SessionInitializeTransaction ();
                lineaPedidoCAD = new LineaPedidoCAD (session);
                lin1 = new LineaPedidoCEN (lineaPedidoCAD);



                // Write here your custom transaction ...


                //PRECONDICIONES

                if (p_oid == 0)
                        throw new Exception ("Ninguna linea proporcionado");

                if (lin1.DameLineaPedidoOID (p_oid) == null)
                        throw new Exception ("La  linea de pedido " + p_oid + " no existe");


                LineaPedidoEN linEN = lin1.DameLineaPedidoOID (p_oid);


                // float total = 0;

                if (linEN.Pedido.Estado == Enumerated.UltrAthletics.EstadoPedidoEnum.carrito) {
                        total = linEN.Unidades * linEN.Producto.Precio;
                }
                else{
                        total = linEN.Unidades * linEN.Precio;
                }

                Console.WriteLine (linEN.Unidades + " de " + linEN.Producto.Nombre + " EL precio total de la linea es: " + total);


                if (total == 0)
                        throw new NotImplementedException ("Method GetTotalLinea() not yet implemented.");

                SessionCommit ();

                return total;
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }
        return total;


        /*PROTECTED REGION END*/
}
}
}
