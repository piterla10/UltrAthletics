
using System;
// Definición clase CategoriaEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class CategoriaEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> producto;



/**
 *	Atributo evento
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.EventoEN> evento;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN> usuario;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.EventoEN> Evento {
        get { return evento; } set { evento = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}





public CategoriaEN()
{
        producto = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>();
        evento = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.EventoEN>();
        usuario = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN>();
}



public CategoriaEN(string nombre, string descripcion, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> producto, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.EventoEN> evento, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN> usuario
                   )
{
        this.init (Nombre, descripcion, producto, evento, usuario);
}


public CategoriaEN(CategoriaEN categoria)
{
        this.init (Nombre, categoria.Descripcion, categoria.Producto, categoria.Evento, categoria.Usuario);
}

private void init (string nombre
                   , string descripcion, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> producto, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.EventoEN> evento, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN> usuario)
{
        this.Nombre = nombre;


        this.Descripcion = descripcion;

        this.Producto = producto;

        this.Evento = evento;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CategoriaEN t = obj as CategoriaEN;
        if (t == null)
                return false;
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
