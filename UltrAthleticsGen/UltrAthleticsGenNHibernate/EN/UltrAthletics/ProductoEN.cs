
using System;
// Definición clase ProductoEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class ProductoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo stock
 */
private int stock;



/**
 *	Atributo descuento
 */
private float descuento;



/**
 *	Atributo imagen
 */
private System.Collections.Generic.IList<string> imagen;



/**
 *	Atributo categoria
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> categoria;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN> valoracion;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN> lineaPedido;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN> usuario;



/**
 *	Atributo peso
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN> peso;



/**
 *	Atributo sabor
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN> sabor;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual int Stock {
        get { return stock; } set { stock = value;  }
}



public virtual float Descuento {
        get { return descuento; } set { descuento = value;  }
}



public virtual System.Collections.Generic.IList<string> Imagen {
        get { return imagen; } set { imagen = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN> Peso {
        get { return peso; } set { peso = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN> Sabor {
        get { return sabor; } set { sabor = value;  }
}





public ProductoEN()
{
        categoria = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN>();
        valoracion = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN>();
        lineaPedido = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN>();
        usuario = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN>();
        peso = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN>();
        sabor = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN>();
}



public ProductoEN(int id, string nombre, string descripcion, float precio, int stock, float descuento, System.Collections.Generic.IList<string> imagen, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> categoria, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN> valoracion, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN> usuario, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN> peso, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN> sabor
                  )
{
        this.init (Id, nombre, descripcion, precio, stock, descuento, imagen, categoria, valoracion, lineaPedido, usuario, peso, sabor);
}


public ProductoEN(ProductoEN producto)
{
        this.init (Id, producto.Nombre, producto.Descripcion, producto.Precio, producto.Stock, producto.Descuento, producto.Imagen, producto.Categoria, producto.Valoracion, producto.LineaPedido, producto.Usuario, producto.Peso, producto.Sabor);
}

private void init (int id
                   , string nombre, string descripcion, float precio, int stock, float descuento, System.Collections.Generic.IList<string> imagen, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> categoria, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN> valoracion, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN> usuario, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN> peso, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN> sabor)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Precio = precio;

        this.Stock = stock;

        this.Descuento = descuento;

        this.Imagen = imagen;

        this.Categoria = categoria;

        this.Valoracion = valoracion;

        this.LineaPedido = lineaPedido;

        this.Usuario = usuario;

        this.Peso = peso;

        this.Sabor = sabor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoEN t = obj as ProductoEN;
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
