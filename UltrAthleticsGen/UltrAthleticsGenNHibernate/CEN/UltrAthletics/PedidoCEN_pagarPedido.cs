
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
using UltrAthleticsGenNHibernate.Enumerated.UltrAthletics;


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_pagarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class PedidoCEN
{
public void PagarPedido (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_pagarPedido) ENABLED START*/

        if (p_oid == 0) throw new Exception ("el oid del pedido no es valido");
        PedidoEN pedEN = _IPedidoCAD.ReadOIDDefault (p_oid);
        if (pedEN.Estado != EstadoPedidoEnum.carrito) throw new Exception ("El estado del pedido no es carrito");

        PedidoCEN pedidoCEN = new PedidoCEN ();
        pedidoCEN.ModificarPedido (p_oid, EstadoPedidoEnum.preparando);

        /*PROTECTED REGION END*/
}
}
}
