
using System;
// Definición clase UsuarioEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class UsuarioEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo fechaNac
 */
private Nullable<DateTime> fechaNac;



/**
 *	Atributo altura
 */
private float altura;



/**
 *	Atributo peso
 */
private float peso;



/**
 *	Atributo imc
 */
private float imc;



/**
 *	Atributo estilo
 */
private UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstiloVidaEnum estilo;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo direccion
 */
private System.Collections.Generic.IList<string> direccion;



/**
 *	Atributo tarjeta
 */
private System.Collections.Generic.IList<string> tarjeta;



/**
 *	Atributo pass
 */
private String pass;



/**
 *	Atributo proteinas
 */
private float proteinas;



/**
 *	Atributo hidratos
 */
private float hidratos;



/**
 *	Atributo grasas
 */
private float grasas;



/**
 *	Atributo calorias
 */
private float calorias;



/**
 *	Atributo objetivo
 */
private UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.ObjetivosEnum objetivo;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN> valoracion;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN> pedido;



/**
 *	Atributo categoria
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> categoria;



/**
 *	Atributo listaDeseados
 */
private System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> listaDeseados;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual Nullable<DateTime> FechaNac {
        get { return fechaNac; } set { fechaNac = value;  }
}



public virtual float Altura {
        get { return altura; } set { altura = value;  }
}



public virtual float Peso {
        get { return peso; } set { peso = value;  }
}



public virtual float Imc {
        get { return imc; } set { imc = value;  }
}



public virtual UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstiloVidaEnum Estilo {
        get { return estilo; } set { estilo = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual System.Collections.Generic.IList<string> Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual System.Collections.Generic.IList<string> Tarjeta {
        get { return tarjeta; } set { tarjeta = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}



public virtual float Proteinas {
        get { return proteinas; } set { proteinas = value;  }
}



public virtual float Hidratos {
        get { return hidratos; } set { hidratos = value;  }
}



public virtual float Grasas {
        get { return grasas; } set { grasas = value;  }
}



public virtual float Calorias {
        get { return calorias; } set { calorias = value;  }
}



public virtual UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.ObjetivosEnum Objetivo {
        get { return objetivo; } set { objetivo = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> ListaDeseados {
        get { return listaDeseados; } set { listaDeseados = value;  }
}





public UsuarioEN()
{
        valoracion = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN>();
        pedido = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN>();
        categoria = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN>();
        listaDeseados = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>();
}



public UsuarioEN(string email, string nombre, Nullable<DateTime> fechaNac, float altura, float peso, float imc, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstiloVidaEnum estilo, string telefono, System.Collections.Generic.IList<string> direccion, System.Collections.Generic.IList<string> tarjeta, String pass, float proteinas, float hidratos, float grasas, float calorias, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.ObjetivosEnum objetivo, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN> valoracion, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN> pedido, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> categoria, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> listaDeseados
                 )
{
        this.init (Email, nombre, fechaNac, altura, peso, imc, estilo, telefono, direccion, tarjeta, pass, proteinas, hidratos, grasas, calorias, objetivo, valoracion, pedido, categoria, listaDeseados);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Email, usuario.Nombre, usuario.FechaNac, usuario.Altura, usuario.Peso, usuario.Imc, usuario.Estilo, usuario.Telefono, usuario.Direccion, usuario.Tarjeta, usuario.Pass, usuario.Proteinas, usuario.Hidratos, usuario.Grasas, usuario.Calorias, usuario.Objetivo, usuario.Valoracion, usuario.Pedido, usuario.Categoria, usuario.ListaDeseados);
}

private void init (string email
                   , string nombre, Nullable<DateTime> fechaNac, float altura, float peso, float imc, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstiloVidaEnum estilo, string telefono, System.Collections.Generic.IList<string> direccion, System.Collections.Generic.IList<string> tarjeta, String pass, float proteinas, float hidratos, float grasas, float calorias, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.ObjetivosEnum objetivo, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN> valoracion, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN> pedido, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> categoria, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> listaDeseados)
{
        this.Email = email;


        this.Nombre = nombre;

        this.FechaNac = fechaNac;

        this.Altura = altura;

        this.Peso = peso;

        this.Imc = imc;

        this.Estilo = estilo;

        this.Telefono = telefono;

        this.Direccion = direccion;

        this.Tarjeta = tarjeta;

        this.Pass = pass;

        this.Proteinas = proteinas;

        this.Hidratos = hidratos;

        this.Grasas = grasas;

        this.Calorias = calorias;

        this.Objetivo = objetivo;

        this.Valoracion = valoracion;

        this.Pedido = pedido;

        this.Categoria = categoria;

        this.ListaDeseados = listaDeseados;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Email.Equals (t.Email))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Email.GetHashCode ();
        return hash;
}
}
}
