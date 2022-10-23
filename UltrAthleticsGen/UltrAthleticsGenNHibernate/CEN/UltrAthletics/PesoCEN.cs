

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
 *      Definition of the class PesoCEN
 *
 */
public partial class PesoCEN
{
private IPesoCAD _IPesoCAD;

public PesoCEN()
{
        this._IPesoCAD = new PesoCAD ();
}

public PesoCEN(IPesoCAD _IPesoCAD)
{
        this._IPesoCAD = _IPesoCAD;
}

public IPesoCAD get_IPesoCAD ()
{
        return this._IPesoCAD;
}

public string CrearPeso (string p_cantidad)
{
        PesoEN pesoEN = null;
        string oid;

        //Initialized PesoEN
        pesoEN = new PesoEN ();
        pesoEN.Cantidad = p_cantidad;

        //Call to PesoCAD

        oid = _IPesoCAD.CrearPeso (pesoEN);
        return oid;
}

public void ModificarPeso (string p_Peso_OID)
{
        PesoEN pesoEN = null;

        //Initialized PesoEN
        pesoEN = new PesoEN ();
        pesoEN.Cantidad = p_Peso_OID;
        //Call to PesoCAD

        _IPesoCAD.ModificarPeso (pesoEN);
}

public void BorrarPeso (string cantidad
                        )
{
        _IPesoCAD.BorrarPeso (cantidad);
}

public PesoEN DamePesoOID (string cantidad
                           )
{
        PesoEN pesoEN = null;

        pesoEN = _IPesoCAD.DamePesoOID (cantidad);
        return pesoEN;
}

public System.Collections.Generic.IList<PesoEN> DamePesoTodos (int first, int size)
{
        System.Collections.Generic.IList<PesoEN> list = null;

        list = _IPesoCAD.DamePesoTodos (first, size);
        return list;
}
}
}
