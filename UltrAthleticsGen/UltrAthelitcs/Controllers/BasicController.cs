using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
<<<<<<< Updated upstream
using NHibernate;
using UltrAthleticsGenNHibernate.Exceptions;
=======
>>>>>>> Stashed changes
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;

public class BasicController : Controller
{
<<<<<<< Updated upstream
    protected ISession session;

    protected BasicController()
    {
    }

    protected void SessionInitialize()
    {
        if (session == null)
        {
            session = NHibernateHelper.OpenSession();
=======
    public class BasicController : Controller
    {
        protected ISession session;

        protected BasicController()
        {

        }

        protected void SessionInitialize()
        {
            if(session == null)
            {
                session = NHibernateHelper.OpenSession();
            }
>>>>>>> Stashed changes
        }
    }

<<<<<<< Updated upstream

    protected void SessionClose()
    {
        if (session != null && session.IsOpen)
        {
            session.Close();
            session.Dispose();
            session = null;
=======
        protected void SessionClose()
        {
            if( session != null && session.IsOpen)
            {
                session.Close();
                session.Dispose();
                session = null;
            }
>>>>>>> Stashed changes
        }
    }
}
