
using System;
// Definición clase DevolucionEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class DevolucionEN
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



/**
 *	Atributo creacion
 */
private string creacion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual string Motivo {
        get { return motivo; } set { motivo = value;  }
}



public virtual string Creacion {
        get { return creacion; } set { creacion = value;  }
}





public DevolucionEN()
{
}



public DevolucionEN(int id, UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido, string motivo, string creacion
                    )
{
        this.init (Id, pedido, motivo, creacion);
}


public DevolucionEN(DevolucionEN devolucion)
{
        this.init (Id, devolucion.Pedido, devolucion.Motivo, devolucion.Creacion);
}

private void init (int id
                   , UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido, string motivo, string creacion)
{
        this.Id = id;


        this.Pedido = pedido;

        this.Motivo = motivo;

        this.Creacion = creacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DevolucionEN t = obj as DevolucionEN;
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
