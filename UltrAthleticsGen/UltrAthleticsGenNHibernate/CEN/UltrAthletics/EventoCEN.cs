

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

public int CrearEvento (Nullable<DateTime> p_fecha, string p_url, string p_imagen, string p_nombre)
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

        oid = _IEventoCAD.CrearEvento (eventoEN);
        return oid;
}

public void ModificarEvento (int p_Evento_OID, Nullable<DateTime> p_fecha, string p_url, string p_imagen, string p_nombre)
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

        _IEventoCAD.ModificarEvento (eventoEN);
}

public void BorrarEvento (int id
                          )
{
        _IEventoCAD.BorrarEvento (id);
}

public EventoEN DameEventoOID (int id
                               )
{
        EventoEN eventoEN = null;

        eventoEN = _IEventoCAD.DameEventoOID (id);
        return eventoEN;
}

public System.Collections.Generic.IList<EventoEN> DameEventoTodos (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> list = null;

        list = _IEventoCAD.DameEventoTodos (first, size);
        return list;
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.EventoEN> DameEventoPorCategoria (string categ)
{
        return _IEventoCAD.DameEventoPorCategoria (categ);
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.EventoEN> DameEventoPorMes (int? anno, int ? mes)
{
        return _IEventoCAD.DameEventoPorMes (anno, mes);
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.EventoEN> DameEventoPorDia (int? anno, int? mes, int ? dia)
{
        return _IEventoCAD.DameEventoPorDia (anno, mes, dia);
}
}
}
