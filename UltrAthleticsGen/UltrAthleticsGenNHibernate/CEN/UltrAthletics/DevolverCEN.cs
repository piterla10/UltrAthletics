

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
 *      Definition of the class DevolverCEN
 *
 */
public partial class DevolverCEN
{
private IDevolverCAD _IDevolverCAD;

public DevolverCEN()
{
        this._IDevolverCAD = new DevolverCAD ();
}

public DevolverCEN(IDevolverCAD _IDevolverCAD)
{
        this._IDevolverCAD = _IDevolverCAD;
}

public IDevolverCAD get_IDevolverCAD ()
{
        return this._IDevolverCAD;
}

public int CrearDevolucion (int p_pedido, string p_motivo)
{
        DevolverEN devolverEN = null;
        int oid;

        //Initialized DevolverEN
        devolverEN = new DevolverEN ();

        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                devolverEN.Pedido = new UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN ();
                devolverEN.Pedido.Id = p_pedido;
        }

        devolverEN.Motivo = p_motivo;

        //Call to DevolverCAD

        oid = _IDevolverCAD.CrearDevolucion (devolverEN);
        return oid;
}

public void ModificarDevolucion (int p_Devolver_OID, string p_motivo)
{
        DevolverEN devolverEN = null;

        //Initialized DevolverEN
        devolverEN = new DevolverEN ();
        devolverEN.Id = p_Devolver_OID;
        devolverEN.Motivo = p_motivo;
        //Call to DevolverCAD

        _IDevolverCAD.ModificarDevolucion (devolverEN);
}

public void BorrarDevolucion (int id
                              )
{
        _IDevolverCAD.BorrarDevolucion (id);
}
}
}
