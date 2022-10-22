

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
 *      Definition of the class LineaPedidoCEN
 *
 */
public partial class LineaPedidoCEN
{
private ILineaPedidoCAD _ILineaPedidoCAD;

public LineaPedidoCEN()
{
        this._ILineaPedidoCAD = new LineaPedidoCAD ();
}

public LineaPedidoCEN(ILineaPedidoCAD _ILineaPedidoCAD)
{
        this._ILineaPedidoCAD = _ILineaPedidoCAD;
}

public ILineaPedidoCAD get_ILineaPedidoCAD ()
{
        return this._ILineaPedidoCAD;
}

public int CrearLinea (int p_unidades, int p_pedido, float p_precio, int p_producto)
{
        LineaPedidoEN lineaPedidoEN = null;
        int oid;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Unidades = p_unidades;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                lineaPedidoEN.Pedido = new UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN ();
                lineaPedidoEN.Pedido.Id = p_pedido;
        }

        lineaPedidoEN.Precio = p_precio;


        if (p_producto != -1) {
                // El argumento p_producto -> Property producto es oid = false
                // Lista de oids id
                lineaPedidoEN.Producto = new UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN ();
                lineaPedidoEN.Producto.Id = p_producto;
        }

        //Call to LineaPedidoCAD

        oid = _ILineaPedidoCAD.CrearLinea (lineaPedidoEN);
        return oid;
}

public void ModificarLinea (int p_LineaPedido_OID, int p_unidades, float p_precio)
{
        LineaPedidoEN lineaPedidoEN = null;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Id = p_LineaPedido_OID;
        lineaPedidoEN.Unidades = p_unidades;
        lineaPedidoEN.Precio = p_precio;
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.ModificarLinea (lineaPedidoEN);
}

public void Borrar (int id
                    )
{
        _ILineaPedidoCAD.Borrar (id);
}

public LineaPedidoEN ReadOID (int id
                              )
{
        LineaPedidoEN lineaPedidoEN = null;

        lineaPedidoEN = _ILineaPedidoCAD.ReadOID (id);
        return lineaPedidoEN;
}

public System.Collections.Generic.IList<LineaPedidoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LineaPedidoEN> list = null;

        list = _ILineaPedidoCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN> VerLineasPorPedido (int ped)
{
        return _ILineaPedidoCAD.VerLineasPorPedido (ped);
}
}
}
