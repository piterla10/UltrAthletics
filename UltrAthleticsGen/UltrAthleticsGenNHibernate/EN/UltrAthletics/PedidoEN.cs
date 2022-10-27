
using System;
// Definición clase PedidoEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class PedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fecha
 */
private string fecha;



/**
 *	Atributo direccion
 */
private string direccion;



/**
 *	Atributo tarjeta
 */
private string tarjeta;



/**
 *	Atributo estado
 */
private UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstadoPedidoEnum estado;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN> lineaPedido;



/**
 *	Atributo usuario
 */
private UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN usuario;



/**
 *	Atributo descuento
 */
private double descuento;



/**
 *	Atributo seguimiento
 */
private string seguimiento;



/**
 *	Atributo factura
 */
private UltrAthleticsGenNHibernate.EN.UltrAthletics.FacturaEN factura;



/**
 *	Atributo devolver
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.DevolucionEN> devolver;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual string Tarjeta {
        get { return tarjeta; } set { tarjeta = value;  }
}



public virtual UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstadoPedidoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual double Descuento {
        get { return descuento; } set { descuento = value;  }
}



public virtual string Seguimiento {
        get { return seguimiento; } set { seguimiento = value;  }
}



public virtual UltrAthleticsGenNHibernate.EN.UltrAthletics.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.DevolucionEN> Devolver {
        get { return devolver; } set { devolver = value;  }
}





public PedidoEN()
{
        lineaPedido = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN>();
        devolver = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.DevolucionEN>();
}



public PedidoEN(int id, string fecha, string direccion, string tarjeta, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstadoPedidoEnum estado, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN> lineaPedido, UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN usuario, double descuento, string seguimiento, UltrAthleticsGenNHibernate.EN.UltrAthletics.FacturaEN factura, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.DevolucionEN> devolver
                )
{
        this.init (Id, fecha, direccion, tarjeta, estado, lineaPedido, usuario, descuento, seguimiento, factura, devolver);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (Id, pedido.Fecha, pedido.Direccion, pedido.Tarjeta, pedido.Estado, pedido.LineaPedido, pedido.Usuario, pedido.Descuento, pedido.Seguimiento, pedido.Factura, pedido.Devolver);
}

private void init (int id
                   , string fecha, string direccion, string tarjeta, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstadoPedidoEnum estado, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN> lineaPedido, UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN usuario, double descuento, string seguimiento, UltrAthleticsGenNHibernate.EN.UltrAthletics.FacturaEN factura, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.DevolucionEN> devolver)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Direccion = direccion;

        this.Tarjeta = tarjeta;

        this.Estado = estado;

        this.LineaPedido = lineaPedido;

        this.Usuario = usuario;

        this.Descuento = descuento;

        this.Seguimiento = seguimiento;

        this.Factura = factura;

        this.Devolver = devolver;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
