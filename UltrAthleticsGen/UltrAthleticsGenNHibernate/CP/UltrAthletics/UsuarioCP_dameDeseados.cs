
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



/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CP.UltrAthletics_Usuario_dameDeseados) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CP.UltrAthletics
{
public partial class UsuarioCP : BasicCP
{
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameDeseados (string usuario)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CP.UltrAthletics_Usuario_dameDeseados) ENABLED START*/

        IProductoCAD productoCAD = null;
        ProductoCEN productoCEN = null;

        System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>  result = null;


        try
        {
                SessionInitializeTransaction ();
                productoCAD = new ProductoCAD (session);
                productoCEN = new ProductoCEN (productoCAD);

                result = productoCEN.DameDeseadosPorUsuario (usuario);

                SessionCommit ();
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
