
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_pagarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class PedidoCEN
{
public void PagarPedido (int p_oid, string direccion, string tarjeta, double descuento)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_pagarPedido) ENABLED START*/

        PedidoCAD pedidoCAD = new PedidoCAD ();
        PedidoCEN pedidoCEN = new PedidoCEN ();
        PedidoEN pedEN = pedidoCEN.DamePedidoOID (p_oid);

        if (pedEN.Estado != Enumerated.UltrAthletics.EstadoPedidoEnum.carrito) throw new Exception ("El estado del pedido no es carrito");

        pedidoCEN.GenerarCodigoLocalizacion (p_oid);
        pedEN = pedidoCEN.DamePedidoOID (p_oid);

        Console.WriteLine ("Codigo de seguimiento: " + pedEN.Seguimiento);

        pedEN.Estado = Enumerated.UltrAthletics.EstadoPedidoEnum.preparando;

        pedEN.Fecha = DateTime.Today.Date;
        pedEN.Direccion = direccion;
        pedEN.Tarjeta = tarjeta;
        pedEN.Descuento = descuento;

        pedidoCAD.ModifyDefault (pedEN);

        /*PROTECTED REGION END*/
}
}
}
