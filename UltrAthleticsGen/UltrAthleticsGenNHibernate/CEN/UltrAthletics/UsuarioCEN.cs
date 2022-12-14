

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UltrAthleticsGenNHibernate.Exceptions;

using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;


namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
/*
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string IniciarSesion (string p_Usuario_OID, string p_pass)
{
        string result = null;
        UsuarioEN en = _IUsuarioCAD.ReadOIDDefault (p_Usuario_OID);

        if (en != null && en.Pass.Equals (Utils.Util.GetEncondeMD5 (p_pass)))
                result = this.GetToken (en.Email);

        return result;
}

public string CrearUsuario (string p_email, String p_pass, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.RolesEnum p_rol)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_email;

        usuarioEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        usuarioEN.Rol = p_rol;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.CrearUsuario (usuarioEN);
        return oid;
}

public void ModificarUsuario (string p_Usuario_OID, String p_pass, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.RolesEnum p_rol)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_Usuario_OID;
        usuarioEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        usuarioEN.Rol = p_rol;
        //Call to UsuarioCAD

        _IUsuarioCAD.ModificarUsuario (usuarioEN);
}

public void BorrarUsuario (string email
                           )
{
        _IUsuarioCAD.BorrarUsuario (email);
}

public UsuarioEN DameUsuarioOID (string email
                                 )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.DameUsuarioOID (email);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> DameUsuarioTodos (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.DameUsuarioTodos (first, size);
        return list;
}
public void AnyadirCategoriaPreferencia (string p_Usuario_OID, System.Collections.Generic.IList<string> p_categoria_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.AnyadirCategoriaPreferencia (p_Usuario_OID, p_categoria_OIDs);
}
public void EliminarCategoriaPreferencia (string p_Usuario_OID, System.Collections.Generic.IList<string> p_categoria_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.EliminarCategoriaPreferencia (p_Usuario_OID, p_categoria_OIDs);
}
public void AnyadirDeseado (string p_Usuario_OID, System.Collections.Generic.IList<int> p_listaDeseados_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.AnyadirDeseado (p_Usuario_OID, p_listaDeseados_OIDs);
}
public void EliminarDeseado (string p_Usuario_OID, System.Collections.Generic.IList<int> p_listaDeseados_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.EliminarDeseado (p_Usuario_OID, p_listaDeseados_OIDs);
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN> DameUsuarioPorCategoria (string categoria)
{
        return _IUsuarioCAD.DameUsuarioPorCategoria (categoria);
}



private string Encode (string email)
{
        var payload = new Dictionary<string, object>(){
                { "email", email }
        };
        string token = Jose.JWT.Encode (payload, Utils.Util.getKey (), Jose.JwsAlgorithm.HS256);

        return token;
}

public string GetToken (string email)
{
        UsuarioEN en = _IUsuarioCAD.ReadOIDDefault (email);
        string token = Encode (en.Email);

        return token;
}
public string CheckToken (string token)
{
        string result = null;

        try
        {
                string decodedToken = Utils.Util.Decode (token);



                string id = (string)ObtenerEMAIL (decodedToken);

                UsuarioEN en = _IUsuarioCAD.ReadOIDDefault (id);

                if (en != null && ((string)en.Email).Equals (ObtenerEMAIL (decodedToken))
                    ) {
                        result = id;
                }
                else throw new ModelException ("El token es incorrecto");
        } catch (Exception e)
        {
                throw new ModelException ("El token es incorrecto");
        }

        return result;
}


public string ObtenerEMAIL (string decodedToken)
{
        try
        {
                Dictionary<string, object> results = JsonConvert.DeserializeObject<Dictionary<string, object> >(decodedToken);
                string email = (string)results ["email"];
                return email;
        }
        catch
        {
                throw new Exception ("El token enviado no es correcto");
        }
}
}
}
