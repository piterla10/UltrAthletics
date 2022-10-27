
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
 * Clase Devolver:
 *
 */

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial class DevolverCAD : BasicCAD, IDevolverCAD
{
public DevolverCAD() : base ()
{
}

public DevolverCAD(ISession sessionAux) : base (sessionAux)
{
}



public DevolverEN ReadOIDDefault (int id
                                  )
{
        DevolverEN devolverEN = null;

        try
        {
                SessionInitializeTransaction ();
                devolverEN = (DevolverEN)session.Get (typeof(DevolverEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolverCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return devolverEN;
}

public System.Collections.Generic.IList<DevolverEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DevolverEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DevolverEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<DevolverEN>();
                        else
                                result = session.CreateCriteria (typeof(DevolverEN)).List<DevolverEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolverCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DevolverEN devolver)
{
        try
        {
                SessionInitializeTransaction ();
                DevolverEN devolverEN = (DevolverEN)session.Load (typeof(DevolverEN), devolver.Id);


                devolverEN.Motivo = devolver.Motivo;

                session.Update (devolverEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolverCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearDevolucion (DevolverEN devolver)
{
        try
        {
                SessionInitializeTransaction ();
                if (devolver.Pedido != null) {
                        // Argumento OID y no colección.
                        devolver.Pedido = (UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN), devolver.Pedido.Id);

                        devolver.Pedido.Devolver
                        .Add (devolver);
                }

                session.Save (devolver);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolverCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return devolver.Id;
}

public void ModificarDevolucion (DevolverEN devolver)
{
        try
        {
                SessionInitializeTransaction ();
                DevolverEN devolverEN = (DevolverEN)session.Load (typeof(DevolverEN), devolver.Id);

                devolverEN.Motivo = devolver.Motivo;

                session.Update (devolverEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolverCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarDevolucion (int id
                              )
{
        try
        {
                SessionInitializeTransaction ();
                DevolverEN devolverEN = (DevolverEN)session.Load (typeof(DevolverEN), id);
                session.Delete (devolverEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolverCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
