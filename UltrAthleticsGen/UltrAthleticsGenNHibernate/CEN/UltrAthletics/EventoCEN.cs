

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
 *      Definition of the class EventoCEN
 *
 */
public partial class EventoCEN
{
private IEventoCAD _IEventoCAD;

public EventoCEN()
{
        this._IEventoCAD = new EventoCAD ();
}

public EventoCEN(IEventoCAD _IEventoCAD)
{
        this._IEventoCAD = _IEventoCAD;
}

public IEventoCAD get_IEventoCAD ()
{
        return this._IEventoCAD;
}

public int CrearCategoria (Nullable<DateTime> p_fecha, string p_url, string p_imagen, string p_nombre)
{
        EventoEN eventoEN = null;
        int oid;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Fecha = p_fecha;

        eventoEN.Url = p_url;

        eventoEN.Imagen = p_imagen;

        eventoEN.Nombre = p_nombre;

        //Call to EventoCAD

        oid = _IEventoCAD.CrearCategoria (eventoEN);
        return oid;
}

public void ModificarCategoria (int p_Evento_OID, Nullable<DateTime> p_fecha, string p_url, string p_imagen, string p_nombre)
{
        EventoEN eventoEN = null;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Id = p_Evento_OID;
        eventoEN.Fecha = p_fecha;
        eventoEN.Url = p_url;
        eventoEN.Imagen = p_imagen;
        eventoEN.Nombre = p_nombre;
        //Call to EventoCAD

        _IEventoCAD.ModificarCategoria (eventoEN);
}

public void Borrar (int id
                    )
{
        _IEventoCAD.Borrar (id);
}

public EventoEN ReadOID (int id
                         )
{
        EventoEN eventoEN = null;

        eventoEN = _IEventoCAD.ReadOID (id);
        return eventoEN;
}

public System.Collections.Generic.IList<EventoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> list = null;

        list = _IEventoCAD.ReadAll (first, size);
        return list;
}
}
}
