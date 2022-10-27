

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
 *      Definition of the class DevolucionCEN
 *
 */
public partial class DevolucionCEN
{
private IDevolucionCAD _IDevolucionCAD;

public DevolucionCEN()
{
        this._IDevolucionCAD = new DevolucionCAD ();
}

public DevolucionCEN(IDevolucionCAD _IDevolucionCAD)
{
        this._IDevolucionCAD = _IDevolucionCAD;
}

public IDevolucionCAD get_IDevolucionCAD ()
{
        return this._IDevolucionCAD;
}

public int CrearDevolucion (int p_pedido, string p_motivo)
{
        DevolucionEN devolucionEN = null;
        int oid;

        //Initialized DevolucionEN
        devolucionEN = new DevolucionEN ();

        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                devolucionEN.Pedido = new UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN ();
                devolucionEN.Pedido.Id = p_pedido;
        }

        devolucionEN.Motivo = p_motivo;

        //Call to DevolucionCAD

        oid = _IDevolucionCAD.CrearDevolucion (devolucionEN);
        return oid;
}

public void ModificarDevolucion (int p_Devolucion_OID, string p_motivo)
{
        DevolucionEN devolucionEN = null;

        //Initialized DevolucionEN
        devolucionEN = new DevolucionEN ();
        devolucionEN.Id = p_Devolucion_OID;
        devolucionEN.Motivo = p_motivo;
        //Call to DevolucionCAD

        _IDevolucionCAD.ModificarDevolucion (devolucionEN);
}

public void BorrarDevolucion (int id
                              )
{
        _IDevolucionCAD.BorrarDevolucion (id);
}

public DevolucionEN DameDevolucionOID (int id
                                       )
{
        DevolucionEN devolucionEN = null;

        devolucionEN = _IDevolucionCAD.DameDevolucionOID (id);
        return devolucionEN;
}

public System.Collections.Generic.IList<DevolucionEN> DameTodosDevolucion (int first, int size)
{
        System.Collections.Generic.IList<DevolucionEN> list = null;

        list = _IDevolucionCAD.DameTodosDevolucion (first, size);
        return list;
}
}
}
