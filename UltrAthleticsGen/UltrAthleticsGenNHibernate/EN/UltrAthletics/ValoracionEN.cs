
using System;
// Definición clase ValoracionEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class ValoracionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo comentario
 */
private string comentario;



/**
 *	Atributo valor
 */
private int valor;



/**
 *	Atributo usuario
 */
private UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN usuario;



/**
 *	Atributo producto
 */
private UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN producto;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual int Valor {
        get { return valor; } set { valor = value;  }
}



public virtual UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}





public ValoracionEN()
{
}



public ValoracionEN(int id, string comentario, int valor, UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN usuario, UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN producto
                    )
{
        this.init (Id, comentario, valor, usuario, producto);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Id, valoracion.Comentario, valoracion.Valor, valoracion.Usuario, valoracion.Producto);
}

private void init (int id
                   , string comentario, int valor, UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN usuario, UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN producto)
{
        this.Id = id;


        this.Comentario = comentario;

        this.Valor = valor;

        this.Usuario = usuario;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionEN t = obj as ValoracionEN;
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
