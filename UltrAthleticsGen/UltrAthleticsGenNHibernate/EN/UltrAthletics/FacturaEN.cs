
using System;
// Definición clase FacturaEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class FacturaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pedido
 */
private UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public FacturaEN()
{
}



public FacturaEN(int id, UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido
                 )
{
        this.init (Id, pedido);
}


public FacturaEN(FacturaEN factura)
{
        this.init (Id, factura.Pedido);
}

private void init (int id
                   , UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN pedido)
{
        this.Id = id;


        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FacturaEN t = obj as FacturaEN;
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
