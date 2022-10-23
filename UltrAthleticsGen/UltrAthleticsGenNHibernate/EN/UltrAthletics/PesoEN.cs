
using System;
// Definición clase PesoEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class PesoEN
{
/**
 *	Atributo cantidad
 */
private string cantidad;



/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> producto;






public virtual string Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}





public PesoEN()
{
        producto = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>();
}



public PesoEN(string cantidad, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> producto
              )
{
        this.init (Cantidad, producto);
}


public PesoEN(PesoEN peso)
{
        this.init (Cantidad, peso.Producto);
}

private void init (string cantidad
                   , System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> producto)
{
        this.Cantidad = cantidad;


        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PesoEN t = obj as PesoEN;
        if (t == null)
                return false;
        if (Cantidad.Equals (t.Cantidad))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Cantidad.GetHashCode ();
        return hash;
}
}
}
