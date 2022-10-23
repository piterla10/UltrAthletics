

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
 *      Definition of the class SaborCEN
 *
 */
public partial class SaborCEN
{
private ISaborCAD _ISaborCAD;

public SaborCEN()
{
        this._ISaborCAD = new SaborCAD ();
}

public SaborCEN(ISaborCAD _ISaborCAD)
{
        this._ISaborCAD = _ISaborCAD;
}

public ISaborCAD get_ISaborCAD ()
{
        return this._ISaborCAD;
}

public string CrearSabor (string p_nombre)
{
        SaborEN saborEN = null;
        string oid;

        //Initialized SaborEN
        saborEN = new SaborEN ();
        saborEN.Nombre = p_nombre;

        //Call to SaborCAD

        oid = _ISaborCAD.CrearSabor (saborEN);
        return oid;
}

public void ModificarSabor (string p_Sabor_OID)
{
        SaborEN saborEN = null;

        //Initialized SaborEN
        saborEN = new SaborEN ();
        saborEN.Nombre = p_Sabor_OID;
        //Call to SaborCAD

        _ISaborCAD.ModificarSabor (saborEN);
}

public void BorrarSabor (string nombre
                         )
{
        _ISaborCAD.BorrarSabor (nombre);
}

public SaborEN DaneSaborOID (string nombre
                             )
{
        SaborEN saborEN = null;

        saborEN = _ISaborCAD.DaneSaborOID (nombre);
        return saborEN;
}

public System.Collections.Generic.IList<SaborEN> DameSaborTodos (int first, int size)
{
        System.Collections.Generic.IList<SaborEN> list = null;

        list = _ISaborCAD.DameSaborTodos (first, size);
        return list;
}
}
}
