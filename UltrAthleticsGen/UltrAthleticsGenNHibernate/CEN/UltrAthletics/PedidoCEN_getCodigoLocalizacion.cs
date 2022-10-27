
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_getCodigoLocalizacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class PedidoCEN
{
public string GetCodigoLocalizacion (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_getCodigoLocalizacion) ENABLED START*/

        // Write here your custom code...

        PedidoCEN ped1 = new PedidoCEN ();
        PedidoEN pedEN = ped1.DamePedidoOID (p_oid);

        if (pedEN.Estado == Enumerated.UltrAthletics.EstadoPedidoEnum.carrito) {
                throw new Exception ();
        }

        //AQUI UTILIZARIAMOS LA API DE ALGUNA EMPRESA DE MENSAJERIA
        //SE SUSTITUYE POR UN CODIGO GENERADO

        return pedEN.Seguimiento;

        /*PROTECTED REGION END*/
}
}
}
