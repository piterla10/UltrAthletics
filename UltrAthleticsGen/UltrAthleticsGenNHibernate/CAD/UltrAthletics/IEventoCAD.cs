
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface IEventoCAD
{
EventoEN ReadOIDDefault (int id
                         );

void ModifyDefault (EventoEN evento);

System.Collections.Generic.IList<EventoEN> ReadAllDefault (int first, int size);



int New_ (EventoEN evento);

void Modify (EventoEN evento);


void Destroy (int id
              );


EventoEN ReadOID (int id
                  );


System.Collections.Generic.IList<EventoEN> ReadAll (int first, int size);
}
}
