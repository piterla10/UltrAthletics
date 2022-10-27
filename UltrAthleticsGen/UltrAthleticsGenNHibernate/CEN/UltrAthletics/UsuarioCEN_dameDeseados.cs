
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Usuario_dameDeseados) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class UsuarioCEN
{
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameDeseados (string usuario)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Usuario_dameDeseados) ENABLED START*/

        UsuarioCEN usuarioCEN = new UsuarioCEN ();

        UsuarioEN usuarioEN = usuarioCEN.DameUsuarioOID (usuario);

        Console.WriteLine (usuarioEN.ListaDeseados);
        Console.WriteLine ("Lista de deseados de " + usuarioEN.Email);

        foreach (ProductoEN pro in usuarioEN.ListaDeseados) {
                Console.Write ("producto: " + pro.Nombre + " usuario: " + usuarioEN.Email);
        }

        return usuarioEN.ListaDeseados;

        /*PROTECTED REGION END*/
}
}
}
