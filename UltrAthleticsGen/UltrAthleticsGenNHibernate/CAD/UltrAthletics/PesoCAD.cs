
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
 * Clase Peso:
 *
 */

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial class PesoCAD : BasicCAD, IPesoCAD
{
public PesoCAD() : base ()
{
}

public PesoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PesoEN ReadOIDDefault (string cantidad
                              )
{
        PesoEN pesoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pesoEN = (PesoEN)session.Get (typeof(PesoEN), cantidad);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in PesoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pesoEN;
}

public System.Collections.Generic.IList<PesoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PesoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PesoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PesoEN>();
                        else
                                result = session.CreateCriteria (typeof(PesoEN)).List<PesoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in PesoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PesoEN peso)
{
        try
        {
                SessionInitializeTransaction ();
                PesoEN pesoEN = (PesoEN)session.Load (typeof(PesoEN), peso.Cantidad);

                session.Update (pesoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in PesoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string CrearPeso (PesoEN peso)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (peso);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in PesoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return peso.Cantidad;
}

public void ModificarPeso (PesoEN peso)
{
        try
        {
                SessionInitializeTransaction ();
                PesoEN pesoEN = (PesoEN)session.Load (typeof(PesoEN), peso.Cantidad);
                session.Update (pesoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in PesoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarPeso (string cantidad
                        )
{
        try
        {
                SessionInitializeTransaction ();
                PesoEN pesoEN = (PesoEN)session.Load (typeof(PesoEN), cantidad);
                session.Delete (pesoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in PesoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: DamePesoOID
//Con e: PesoEN
public PesoEN DamePesoOID (string cantidad
                           )
{
        PesoEN pesoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pesoEN = (PesoEN)session.Get (typeof(PesoEN), cantidad);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in PesoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pesoEN;
}

public System.Collections.Generic.IList<PesoEN> DamePesoTodos (int first, int size)
{
        System.Collections.Generic.IList<PesoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PesoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PesoEN>();
                else
                        result = session.CreateCriteria (typeof(PesoEN)).List<PesoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in PesoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
