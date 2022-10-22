
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



int CrearCategoria (EventoEN evento);

void ModificarCategoria (EventoEN evento);


void Borrar (int id
             );


EventoEN ReadOID (int id
                  );


System.Collections.Generic.IList<EventoEN> ReadAll (int first, int size);
}
}
