
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Usuario_recuperarContrasenya) ENABLED START*/
using System.Net.Mail;
using System.Net;

/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class UsuarioCEN
{
public void RecuperarContrasenya (string p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Usuario_recuperarContrasenya) ENABLED START*/

        // Write here your custom code...

        UsuarioCEN usuCEN = new UsuarioCEN ();
        UsuarioEN usuEN = new UsuarioEN ();

        usuEN = usuCEN.DameUsuarioOID (p_oid);

        using (MailMessage mailMessage = new MailMessage ())
        {
                mailMessage.To.Add (p_oid);

                mailMessage.Subject = "NUEVO PASSWORD";

                //LLAMADA A GENERADOR DE PASSWORD

                Random rdn = new Random ();
                string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
                int longitud = caracteres.Length;
                char letra;
                int longitudContrasenia = 10;
                string nuevopass = string.Empty;
                for (int i = 0; i < longitudContrasenia; i++) {
                        letra = caracteres [rdn.Next (longitud)];
                        nuevopass += letra.ToString ();
                }



                nuevopass = "nuevacontrase�a";

                mailMessage.Body = "Tu nuevo password es " + nuevopass + " inicie sesi�n, entre a su perfil y modifique el password si lo desea";
                mailMessage.IsBodyHtml = false;

                //MODIFICAR CONTRASE�A DE LA BASE DE DATOS
                usuEN.Pass = "nuevacontrase�a";
                _IUsuarioCAD.ModifyDefault (usuEN);



                mailMessage.From = new MailAddress ("el que manda el correo", "CAMBIO DE PASSWORD");

                using (SmtpClient cliente = new SmtpClient ())
                {
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new NetworkCredential ("el que manda el correo", " el password");
                        cliente.Port = 587;
                        cliente.EnableSsl = true;


                        cliente.Host = "smtp.gmail.com";
                        cliente.Send (mailMessage);
                }
        }

        /*PROTECTED REGION END*/
}
}
}
