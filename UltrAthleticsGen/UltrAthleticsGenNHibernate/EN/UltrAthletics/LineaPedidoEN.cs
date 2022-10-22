
using System;
// Definición clase LineaPedidoEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class LineaPedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo unidades
 */
private int unidades;



/**
 *	Atributo pedido
 */
private UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido;



/**
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo producto
 */
private UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN producto;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Unidades {
        get { return unidades; } set { unidades = value;  }
}



public virtual UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int id, int unidades, UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido, float precio, UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN producto
                     )
{
        this.init (Id, unidades, pedido, precio, producto);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (Id, lineaPedido.Unidades, lineaPedido.Pedido, lineaPedido.Precio, lineaPedido.Producto);
}

private void init (int id
                   , int unidades, UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido, float precio, UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN producto)
{
        this.Id = id;


        this.Unidades = unidades;

        this.Pedido = pedido;

        this.Precio = precio;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
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
