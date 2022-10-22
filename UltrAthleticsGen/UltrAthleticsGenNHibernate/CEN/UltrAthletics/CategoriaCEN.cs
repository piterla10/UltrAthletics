

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
 *      Definition of the class CategoriaCEN
 *
 */
public partial class CategoriaCEN
{
private ICategoriaCAD _ICategoriaCAD;

public CategoriaCEN()
{
        this._ICategoriaCAD = new CategoriaCAD ();
}

public CategoriaCEN(ICategoriaCAD _ICategoriaCAD)
{
        this._ICategoriaCAD = _ICategoriaCAD;
}

public ICategoriaCAD get_ICategoriaCAD ()
{
        return this._ICategoriaCAD;
}

public string CrearCategoria (string p_nombre, string p_descripcion)
{
        CategoriaEN categoriaEN = null;
        string oid;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Nombre = p_nombre;

        categoriaEN.Descripcion = p_descripcion;

        //Call to CategoriaCAD

        oid = _ICategoriaCAD.CrearCategoria (categoriaEN);
        return oid;
}

public void ModificarCategoria (string p_Categoria_OID, string p_descripcion)
{
        CategoriaEN categoriaEN = null;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Nombre = p_Categoria_OID;
        categoriaEN.Descripcion = p_descripcion;
        //Call to CategoriaCAD

        _ICategoriaCAD.ModificarCategoria (categoriaEN);
}

public void Borrar (string nombre
                    )
{
        _ICategoriaCAD.Borrar (nombre);
}

public CategoriaEN ReadOID (string nombre
                            )
{
        CategoriaEN categoriaEN = null;

        categoriaEN = _ICategoriaCAD.ReadOID (nombre);
        return categoriaEN;
}

public System.Collections.Generic.IList<CategoriaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CategoriaEN> list = null;

        list = _ICategoriaCAD.ReadAll (first, size);
        return list;
}
}
}
