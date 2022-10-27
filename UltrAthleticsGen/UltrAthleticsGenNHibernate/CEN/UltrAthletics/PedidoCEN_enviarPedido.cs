
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_enviarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class PedidoCEN
{
public void EnviarPedido (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_enviarPedido) ENABLED START*/

        PedidoCEN pedicen = new PedidoCEN ();
        PedidoEN pedien = pedicen.DamePedidoOID (p_oid);

        //precondiciones
        if (pedien == null) throw new Exception ("El pedido " + p_oid + " no existe");
        if (pedien.Estado != Enumerated.UltrAthletics.EstadoPedidoEnum.preparando) throw new Exception ("No se ha preparado el pedido" + p_oid);


        pedien.Estado = Enumerated.UltrAthletics.EstadoPedidoEnum.enCamino;

        //postcondicion
        pedicen.ModificarPedido (pedien.Id, pedien.Estado);

        /*PROTECTED REGION END*/
}
}
}
