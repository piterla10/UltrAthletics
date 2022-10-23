
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
 * Clase Categoria:
 *
 */

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial class CategoriaCAD : BasicCAD, ICategoriaCAD
{
public CategoriaCAD() : base ()
{
}

public CategoriaCAD(ISession sessionAux) : base (sessionAux)
{
}



public CategoriaEN ReadOIDDefault (string nombre
                                   )
{
        CategoriaEN categoriaEN = null;

        try
        {
                SessionInitializeTransaction ();
                categoriaEN = (CategoriaEN)session.Get (typeof(CategoriaEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoriaEN;
}

public System.Collections.Generic.IList<CategoriaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CategoriaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CategoriaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CategoriaEN>();
                        else
                                result = session.CreateCriteria (typeof(CategoriaEN)).List<CategoriaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CategoriaEN categoria)
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaEN categoriaEN = (CategoriaEN)session.Load (typeof(CategoriaEN), categoria.Nombre);

                categoriaEN.Descripcion = categoria.Descripcion;




                session.Update (categoriaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string CrearCategoria (CategoriaEN categoria)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (categoria);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoria.Nombre;
}

public void ModificarCategoria (CategoriaEN categoria)
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaEN categoriaEN = (CategoriaEN)session.Load (typeof(CategoriaEN), categoria.Nombre);

                categoriaEN.Descripcion = categoria.Descripcion;

                session.Update (categoriaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarCategoria (string nombre
                             )
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaEN categoriaEN = (CategoriaEN)session.Load (typeof(CategoriaEN), nombre);
                session.Delete (categoriaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: DameCategoriaOID
//Con e: CategoriaEN
public CategoriaEN DameCategoriaOID (string nombre
                                     )
{
        CategoriaEN categoriaEN = null;

        try
        {
                SessionInitializeTransaction ();
                categoriaEN = (CategoriaEN)session.Get (typeof(CategoriaEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoriaEN;
}

public System.Collections.Generic.IList<CategoriaEN> DameCategoriaTodos (int first, int size)
{
        System.Collections.Generic.IList<CategoriaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CategoriaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CategoriaEN>();
                else
                        result = session.CreateCriteria (typeof(CategoriaEN)).List<CategoriaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
