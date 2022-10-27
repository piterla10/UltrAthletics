

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
 *      Definition of the class FacturaCEN
 *
 */
public partial class FacturaCEN
{
private IFacturaCAD _IFacturaCAD;

public FacturaCEN()
{
        this._IFacturaCAD = new FacturaCAD ();
}

public FacturaCEN(IFacturaCAD _IFacturaCAD)
{
        this._IFacturaCAD = _IFacturaCAD;
}

public IFacturaCAD get_IFacturaCAD ()
{
        return this._IFacturaCAD;
}

public int CrearFactura (int p_pedido)
{
        FacturaEN facturaEN = null;
        int oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();

        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                facturaEN.Pedido = new UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN ();
                facturaEN.Pedido.Id = p_pedido;
        }

        //Call to FacturaCAD

        oid = _IFacturaCAD.CrearFactura (facturaEN);
        return oid;
}

public void ModificarFactura (int p_Factura_OID)
{
        FacturaEN facturaEN = null;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_Factura_OID;
        //Call to FacturaCAD

        _IFacturaCAD.ModificarFactura (facturaEN);
}

public void BorrarFactura (int id
                           )
{
        _IFacturaCAD.BorrarFactura (id);
}

public FacturaEN DameFacturaOID (int id
                                 )
{
        FacturaEN facturaEN = null;

        facturaEN = _IFacturaCAD.DameFacturaOID (id);
        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> DameFacturaTodos (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> list = null;

        list = _IFacturaCAD.DameFacturaTodos (first, size);
        return list;
}
}
}
