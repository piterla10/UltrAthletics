
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

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;

        System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>  result = null;


        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new  UsuarioCEN (usuarioCAD);

                UsuarioEN usuarioEN = usuarioCEN.DameUsuarioOID (usuario);

                result = usuarioEN.ListaDeseados;

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
