
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



/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CP.UltrAthletics_Pedido_pagarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CP.UltrAthletics
{
public partial class PedidoCP : BasicCP
{
public void PagarPedido (int p_oid, string direccion, string tarjeta, double descuento)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CP.UltrAthletics_Pedido_pagarPedido) ENABLED START*/

        IPedidoCAD pedidoCAD = null;
        PedidoCEN pedidoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                pedidoCAD = new PedidoCAD (session);
                pedidoCEN = new  PedidoCEN (pedidoCAD);



                // Write here your custom transaction ...

                PedidoEN pedEN = pedidoCEN.DamePedidoOID(p_oid);

                if (pedEN.Estado != Enumerated.UltrAthletics.EstadoPedidoEnum.carrito) throw new Exception("El estado del pedido no es carrito");


                pedEN.Estado = Enumerated.UltrAthletics.EstadoPedidoEnum.preparando;

                pedEN.Fecha = DateTime.Today.ToString("f");
                pedEN.Direccion = direccion;
                pedEN.Tarjeta = tarjeta;
                pedEN.Descuento = descuento;

                pedidoCAD.ModifyDefault(pedEN);




                SessionCommit();
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


        /*PROTECTED REGION END*/
}
}
}
