
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
 * Clase Sabor:
 *
 */

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial class SaborCAD : BasicCAD, ISaborCAD
{
public SaborCAD() : base ()
{
}

public SaborCAD(ISession sessionAux) : base (sessionAux)
{
}



public SaborEN ReadOIDDefault (string nombre
                               )
{
        SaborEN saborEN = null;

        try
        {
                SessionInitializeTransaction ();
                saborEN = (SaborEN)session.Get (typeof(SaborEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in SaborCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return saborEN;
}

public System.Collections.Generic.IList<SaborEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SaborEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SaborEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SaborEN>();
                        else
                                result = session.CreateCriteria (typeof(SaborEN)).List<SaborEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in SaborCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SaborEN sabor)
{
        try
        {
                SessionInitializeTransaction ();
                SaborEN saborEN = (SaborEN)session.Load (typeof(SaborEN), sabor.Nombre);

                session.Update (saborEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in SaborCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string CrearSabor (SaborEN sabor)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (sabor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in SaborCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sabor.Nombre;
}

public void ModificarSabor (SaborEN sabor)
{
        try
        {
                SessionInitializeTransaction ();
                SaborEN saborEN = (SaborEN)session.Load (typeof(SaborEN), sabor.Nombre);
                session.Update (saborEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in SaborCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarSabor (string nombre
                         )
{
        try
        {
                SessionInitializeTransaction ();
                SaborEN saborEN = (SaborEN)session.Load (typeof(SaborEN), nombre);
                session.Delete (saborEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in SaborCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: DaneSaborOID
//Con e: SaborEN
public SaborEN DaneSaborOID (string nombre
                             )
{
        SaborEN saborEN = null;

        try
        {
                SessionInitializeTransaction ();
                saborEN = (SaborEN)session.Get (typeof(SaborEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in SaborCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return saborEN;
}

public System.Collections.Generic.IList<SaborEN> DameSaborTodos (int first, int size)
{
        System.Collections.Generic.IList<SaborEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SaborEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<SaborEN>();
                else
                        result = session.CreateCriteria (typeof(SaborEN)).List<SaborEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in SaborCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
