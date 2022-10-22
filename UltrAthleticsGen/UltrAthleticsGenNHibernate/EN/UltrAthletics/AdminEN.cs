
using System;
// Definición clase AdminEN
namespace UltrAthleticsGenNHibernate.EN.UltrAthletics
{
public partial class AdminEN                                                                        : UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN


{
public AdminEN() : base ()
{
}



public AdminEN(string email,
               string nombre, Nullable<DateTime> fechaNac, float altura, float peso, float imc, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.EstiloVidaEnum estilo, string telefono, System.Collections.Generic.IList<string> direccion, System.Collections.Generic.IList<string> tarjeta, String pass, float proteinas, float hidratos, float grasas, float calorias, UltrAthleticsGenNHibernate.Enumerated.UltrAthletics.ObjetivosEnum objetivo, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN> valoracion, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN> pedido, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN> categoria, System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> listaDeseados
               )
{
        this.init (Email, nombre, fechaNac, altura, peso, imc, estilo, telefono, direccion, tarjeta, pass, proteinas, hidratos, grasas, calorias, objetivo, valoracion, pedido, categoria, listaDeseados);
}


public AdminEN(AdminEN admin)
{
        this.init (Email, admin.Nombre, admin.FechaNac, admin.Altura, admin.Peso, admin.Imc, admin.Estilo, admin.Telefono, admin.Direccion, admin.Tarjeta, admin.Pass, admin.Proteinas, admin.Hidratos, admin.Grasas, admin.Calorias, admin.Objetivo, admin.Valoracion, admin.Pedido, admin.Categoria, admin.ListaDeseados);
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
        AdminEN t = obj as AdminEN;
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
