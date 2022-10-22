
using System;
// Definición clase EventoEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class EventoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo url
 */
private string url;



/**
 *	Atributo imagen
 */
private string imagen;



/**
 *	Atributo categoria
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> categoria;



/**
 *	Atributo nombre
 */
private string nombre;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Url {
        get { return url; } set { url = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}





public EventoEN()
{
        categoria = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN>();
}



public EventoEN(int id, Nullable<DateTime> fecha, string url, string imagen, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> categoria, string nombre
                )
{
        this.init (Id, fecha, url, imagen, categoria, nombre);
}


public EventoEN(EventoEN evento)
{
        this.init (Id, evento.Fecha, evento.Url, evento.Imagen, evento.Categoria, evento.Nombre);
}

private void init (int id
                   , Nullable<DateTime> fecha, string url, string imagen, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> categoria, string nombre)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Url = url;

        this.Imagen = imagen;

        this.Categoria = categoria;

        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EventoEN t = obj as EventoEN;
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
