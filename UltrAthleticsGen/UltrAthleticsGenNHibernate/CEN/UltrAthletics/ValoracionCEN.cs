

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
 *      Definition of the class ValoracionCEN
 *
 */
public partial class ValoracionCEN
{
private IValoracionCAD _IValoracionCAD;

public ValoracionCEN()
{
        this._IValoracionCAD = new ValoracionCAD ();
}

public ValoracionCEN(IValoracionCAD _IValoracionCAD)
{
        this._IValoracionCAD = _IValoracionCAD;
}

public IValoracionCAD get_IValoracionCAD ()
{
        return this._IValoracionCAD;
}

public int CrearValoracion (string p_comentario, int p_valor, string p_usuario, int p_producto)
{
        ValoracionEN valoracionEN = null;
        int oid;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Comentario = p_comentario;

        valoracionEN.Valor = p_valor;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                valoracionEN.Usuario = new UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN ();
                valoracionEN.Usuario.Email = p_usuario;
        }


        if (p_producto != -1) {
                // El argumento p_producto -> Property producto es oid = false
                // Lista de oids id
                valoracionEN.Producto = new UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN ();
                valoracionEN.Producto.Id = p_producto;
        }

        //Call to ValoracionCAD

        oid = _IValoracionCAD.CrearValoracion (valoracionEN);
        return oid;
}

public void ModificarValoracion (int p_Valoracion_OID, string p_comentario, int p_valor)
{
        ValoracionEN valoracionEN = null;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Id = p_Valoracion_OID;
        valoracionEN.Comentario = p_comentario;
        valoracionEN.Valor = p_valor;
        //Call to ValoracionCAD

        _IValoracionCAD.ModificarValoracion (valoracionEN);
}

public void BorrarValoracion (int id
                              )
{
        _IValoracionCAD.BorrarValoracion (id);
}

public ValoracionEN DameValoracionOID (int id
                                       )
{
        ValoracionEN valoracionEN = null;

        valoracionEN = _IValoracionCAD.DameValoracionOID (id);
        return valoracionEN;
}

public System.Collections.Generic.IList<ValoracionEN> DameValoracionTodos (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> list = null;

        list = _IValoracionCAD.DameValoracionTodos (first, size);
        return list;
}
}
}
