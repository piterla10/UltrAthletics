

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
 *      Definition of the class PedidoCEN
 *
 */
public partial class PedidoCEN
{
private IPedidoCAD _IPedidoCAD;

public PedidoCEN()
{
        this._IPedidoCAD = new PedidoCAD ();
}

public PedidoCEN(IPedidoCAD _IPedidoCAD)
{
        this._IPedidoCAD = _IPedidoCAD;
}

public IPedidoCAD get_IPedidoCAD ()
{
        return this._IPedidoCAD;
}

public int CrearPedido (string p_fecha, string p_direccion, string p_tarjeta, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstadoPedidoEnum p_estado, string p_usuario, double p_descuento)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Fecha = p_fecha;

        pedidoEN.Direccion = p_direccion;

        pedidoEN.Tarjeta = p_tarjeta;

        pedidoEN.Estado = p_estado;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                pedidoEN.Usuario = new UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN ();
                pedidoEN.Usuario.Email = p_usuario;
        }

        pedidoEN.Descuento = p_descuento;

        //Call to PedidoCAD

        oid = _IPedidoCAD.CrearPedido (pedidoEN);
        return oid;
}

public void ModificarPedido (int p_Pedido_OID, string p_fecha, string p_direccion, string p_tarjeta, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstadoPedidoEnum p_estado, double p_descuento)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_Pedido_OID;
        pedidoEN.Fecha = p_fecha;
        pedidoEN.Direccion = p_direccion;
        pedidoEN.Tarjeta = p_tarjeta;
        pedidoEN.Estado = p_estado;
        pedidoEN.Descuento = p_descuento;
        //Call to PedidoCAD

        _IPedidoCAD.ModificarPedido (pedidoEN);
}

public void BorrarPedido (int id
                          )
{
        _IPedidoCAD.BorrarPedido (id);
}

public PedidoEN DamePedidoOID (int id
                               )
{
        PedidoEN pedidoEN = null;

        pedidoEN = _IPedidoCAD.DamePedidoOID (id);
        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> DamePedidoTodos (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> list = null;

        list = _IPedidoCAD.DamePedidoTodos (first, size);
        return list;
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN> DamePedidoUsuario (string usuario)
{
        return _IPedidoCAD.DamePedidoUsuario (usuario);
}
}
}
