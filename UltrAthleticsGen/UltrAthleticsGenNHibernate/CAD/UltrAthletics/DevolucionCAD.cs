
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
 * Clase Devolucion:
 *
 */

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial class DevolucionCAD : BasicCAD, IDevolucionCAD
{
public DevolucionCAD() : base ()
{
}

public DevolucionCAD(ISession sessionAux) : base (sessionAux)
{
}



public DevolucionEN ReadOIDDefault (int id
                                    )
{
        DevolucionEN devolucionEN = null;

        try
        {
                SessionInitializeTransaction ();
                devolucionEN = (DevolucionEN)session.Get (typeof(DevolucionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolucionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return devolucionEN;
}

public System.Collections.Generic.IList<DevolucionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DevolucionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DevolucionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<DevolucionEN>();
                        else
                                result = session.CreateCriteria (typeof(DevolucionEN)).List<DevolucionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolucionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DevolucionEN devolucion)
{
        try
        {
                SessionInitializeTransaction ();
                DevolucionEN devolucionEN = (DevolucionEN)session.Load (typeof(DevolucionEN), devolucion.Id);


                devolucionEN.Motivo = devolucion.Motivo;

                session.Update (devolucionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolucionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearDevolucion (DevolucionEN devolucion)
{
        try
        {
                SessionInitializeTransaction ();
                if (devolucion.Pedido != null) {
                        // Argumento OID y no colección.
                        devolucion.Pedido = (UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.PedidoEN), devolucion.Pedido.Id);

                        devolucion.Pedido.Devolver
                        .Add (devolucion);
                }

                session.Save (devolucion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolucionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return devolucion.Id;
}

public void ModificarDevolucion (DevolucionEN devolucion)
{
        try
        {
                SessionInitializeTransaction ();
                DevolucionEN devolucionEN = (DevolucionEN)session.Load (typeof(DevolucionEN), devolucion.Id);

                devolucionEN.Motivo = devolucion.Motivo;

                session.Update (devolucionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolucionCAD.", ex);
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
                DevolucionEN devolucionEN = (DevolucionEN)session.Load (typeof(DevolucionEN), id);
                session.Delete (devolucionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolucionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: DameDevolucionOID
//Con e: DevolucionEN
public DevolucionEN DameDevolucionOID (int id
                                       )
{
        DevolucionEN devolucionEN = null;

        try
        {
                SessionInitializeTransaction ();
                devolucionEN = (DevolucionEN)session.Get (typeof(DevolucionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolucionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return devolucionEN;
}

public System.Collections.Generic.IList<DevolucionEN> DameTodosDevolucion (int first, int size)
{
        System.Collections.Generic.IList<DevolucionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DevolucionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<DevolucionEN>();
                else
                        result = session.CreateCriteria (typeof(DevolucionEN)).List<DevolucionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in DevolucionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
