
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using UltrAthleticsGenNHibernate.Exceptions;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;
using UltrAthleticsGenNHibernate.CEN.UltrAthletics;



namespace UltrAthleticsGenNHibernate.CP.UltrAthletics
{
public partial class EventoCP : BasicCP
{
public EventoCP() : base ()
{
}

public EventoCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
