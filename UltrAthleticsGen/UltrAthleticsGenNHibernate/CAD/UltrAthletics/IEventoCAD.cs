
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



int CrearEvento (EventoEN evento);

void ModificarEvento (EventoEN evento);


void BorrarEvento (int id
                   );


EventoEN DameEventoOID (int id
                        );


System.Collections.Generic.IList<EventoEN> DameEventoTodos (int first, int size);


System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.EventoEN> DameEventoPorCategoria (string categ);
}
}
