
using System;
// Definición clase DevolverEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class DevolverEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pedido
 */
private UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido;



/**
 *	Atributo motivo
 */
private string motivo;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual string Motivo {
        get { return motivo; } set { motivo = value;  }
}





public DevolverEN()
{
}



public DevolverEN(int id, UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido, string motivo
                  )
{
        this.init (Id, pedido, motivo);
}


public DevolverEN(DevolverEN devolver)
{
        this.init (Id, devolver.Pedido, devolver.Motivo);
}

private void init (int id
                   , UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido, string motivo)
{
        this.Id = id;


        this.Pedido = pedido;

        this.Motivo = motivo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DevolverEN t = obj as DevolverEN;
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
