
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
public partial class ValoracionCP : BasicCP
{
public ValoracionCP() : base ()
{
}

public ValoracionCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
