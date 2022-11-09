
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_entregarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class PedidoCEN
{
public void EntregarPedido (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_entregarPedido) ENABLED START*/

        if (p_oid == 0) throw new Exception ("el oid del pedido no es valido");
        PedidoEN pedEN = _IPedidoCAD.ReadOIDDefault (p_oid);
        if (pedEN.Estado != Enumerated.UltrAthletics.EstadoPedidoEnum.enCamino) throw new Exception ("El estado del pedido no es enCamino");

        PedidoCEN pedidoCEN = new PedidoCEN ();

        //postcondicion
        pedidoCEN.ModificarPedido (p_oid, Enumerated.UltrAthletics.EstadoPedidoEnum.entregado);

        /*PROTECTED REGION END*/
}
}
}
