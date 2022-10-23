
using System;
using System.Text;
using UltrAthleticsGenNHibernate.CEN.UltrAthletics;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.Exceptions;


/*
 * Clase Usuario:
 *
 */

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
{
public UsuarioCAD() : base ()
{
}

public UsuarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioEN ReadOIDDefault (string email
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Email);

                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.FechaNac = usuario.FechaNac;


                usuarioEN.Altura = usuario.Altura;


                usuarioEN.Peso = usuario.Peso;


                usuarioEN.Imc = usuario.Imc;


                usuarioEN.Estilo = usuario.Estilo;


                usuarioEN.Telefono = usuario.Telefono;


                usuarioEN.Direccion = usuario.Direccion;


                usuarioEN.Tarjeta = usuario.Tarjeta;


                usuarioEN.Pass = usuario.Pass;


                usuarioEN.Proteinas = usuario.Proteinas;


                usuarioEN.Hidratos = usuario.Hidratos;


                usuarioEN.Grasas = usuario.Grasas;


                usuarioEN.Calorias = usuario.Calorias;


                usuarioEN.Objetivo = usuario.Objetivo;






                usuarioEN.Rol = usuario.Rol;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string CrearUsuario (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario.Email;
}

public void ModificarUsuario (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Email);

                usuarioEN.Pass = usuario.Pass;


                usuarioEN.Rol = usuario.Rol;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarUsuario (string email
                           )
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), email);
                session.Delete (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: DameUsuarioOID
//Con e: UsuarioEN
public UsuarioEN DameUsuarioOID (string email
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> DameUsuarioTodos (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuarioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AnyadirCategoriaPreferencia (string p_Usuario_OID, System.Collections.Generic.IList<string> p_categoria_OIDs)
{
        UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN categoriaENAux = null;
                if (usuarioEN.Categoria == null) {
                        usuarioEN.Categoria = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN>();
                }

                foreach (string item in p_categoria_OIDs) {
                        categoriaENAux = new UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN ();
                        categoriaENAux = (UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN), item);
                        categoriaENAux.Usuario.Add (usuarioEN);

                        usuarioEN.Categoria.Add (categoriaENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void EliminarCategoriaPreferencia (string p_Usuario_OID, System.Collections.Generic.IList<string> p_categoria_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN usuarioEN = null;
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);

                UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN categoriaENAux = null;
                if (usuarioEN.Categoria != null) {
                        foreach (string item in p_categoria_OIDs) {
                                categoriaENAux = (UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN), item);
                                if (usuarioEN.Categoria.Contains (categoriaENAux) == true) {
                                        usuarioEN.Categoria.Remove (categoriaENAux);
                                        categoriaENAux.Usuario.Remove (usuarioEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_categoria_OIDs you are trying to unrelationer, doesn't exist in UsuarioEN");
                        }
                }

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void AnyadirDeseado (string p_Usuario_OID, System.Collections.Generic.IList<int> p_listaDeseados_OIDs)
{
        UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN listaDeseadosENAux = null;
                if (usuarioEN.ListaDeseados == null) {
                        usuarioEN.ListaDeseados = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>();
                }

                foreach (int item in p_listaDeseados_OIDs) {
                        listaDeseadosENAux = new UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN ();
                        listaDeseadosENAux = (UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN), item);
                        listaDeseadosENAux.Usuario.Add (usuarioEN);

                        usuarioEN.ListaDeseados.Add (listaDeseadosENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void EliminarDeseado (string p_Usuario_OID, System.Collections.Generic.IList<int> p_listaDeseados_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN usuarioEN = null;
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);

                UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN listaDeseadosENAux = null;
                if (usuarioEN.ListaDeseados != null) {
                        foreach (int item in p_listaDeseados_OIDs) {
                                listaDeseadosENAux = (UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN), item);
                                if (usuarioEN.ListaDeseados.Contains (listaDeseadosENAux) == true) {
                                        usuarioEN.ListaDeseados.Remove (listaDeseadosENAux);
                                        listaDeseadosENAux.Usuario.Remove (usuarioEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_listaDeseados_OIDs you are trying to unrelationer, doesn't exist in UsuarioEN");
                        }
                }

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
