
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Producto_getTotalValoraciones) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class ProductoCEN
{
public int GetTotalValoraciones (int p_oid)
{
            /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Producto_getTotalValoraciones) ENABLED START*/

            

            return proEN.Valoracion;

        /*PROTECTED REGION END*/
}
}
}
