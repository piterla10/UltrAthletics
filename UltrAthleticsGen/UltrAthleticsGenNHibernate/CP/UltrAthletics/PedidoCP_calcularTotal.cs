
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



/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CP.UltrAthletics_Pedido_calcularTotal) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CP.UltrAthletics
{
public partial class PedidoCP : BasicCP
{
public float CalcularTotal (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CP.UltrAthletics_Pedido_calcularTotal) ENABLED START*/

        IPedidoCAD pedidoCAD = null;
        PedidoCEN pedidoCEN = null;
        PedidoEN pedidoEN = null;

        LineaPedidoCP LineaCP = null;

        float result = 0;


        try{
                SessionInitializeTransaction ();
                pedidoCAD = new PedidoCAD (session);
                pedidoCEN = new PedidoCEN (pedidoCAD);

                LineaCP = new LineaPedidoCP (session);


                pedidoEN = pedidoCEN.DamePedidoOID (p_oid);

                IList<LineaPedidoEN> lineas = pedidoEN.LineaPedido;

                foreach (LineaPedidoEN lin in lineas) {
                        result += LineaCP.GetTotalLinea (lin.Id);
                }

                pedidoEN.Total = result;
                //Console.WriteLine ("dentro del codigo: " + pedidoEN.Total);

                pedidoCAD.ModifyDefault (pedidoEN);

               // Console.WriteLine ("dentro del codigo: " + pedidoEN.Total);

                SessionCommit ();

                return result;
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
        return result;


        /*PROTECTED REGION END*/
}
}
}
