
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
public partial class PesoCP : BasicCP
{
public PesoCP() : base ()
{
}

public PesoCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
