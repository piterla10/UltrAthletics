
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_getEstado) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class PedidoCEN
{
public UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstadoPedidoEnum GetEstado (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_getEstado) ENABLED START*/

        // Write here your custom code...
        if (p_oid == null)
                throw new Exception ("No hay estado disponible");
        PedidoEN ped = _IPedidoCAD.ReadOIDDefault (p_oid);
        //Console.WriteLine("El estado del pedido " + ped.Id + " es " + ped.Estado);
        return ped.Estado;
        throw new ModelException ("No se ha podido devolver el estado");

        /*PROTECTED REGION END*/
}
}
}
