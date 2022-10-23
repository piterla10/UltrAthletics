
using System;
// Definición clase SaborEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class SaborEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> producto;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}





public SaborEN()
{
        producto = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>();
}



public SaborEN(string nombre, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> producto
               )
{
        this.init (Nombre, producto);
}


public SaborEN(SaborEN sabor)
{
        this.init (Nombre, sabor.Producto);
}

private void init (string nombre
                   , System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> producto)
{
        this.Nombre = nombre;


        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SaborEN t = obj as SaborEN;
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
