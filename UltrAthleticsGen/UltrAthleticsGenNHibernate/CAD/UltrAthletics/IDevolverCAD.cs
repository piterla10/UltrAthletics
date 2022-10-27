
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface IDevolverCAD
{
DevolverEN ReadOIDDefault (int id
                           );

void ModifyDefault (DevolverEN devolver);

System.Collections.Generic.IList<DevolverEN> ReadAllDefault (int first, int size);



int CrearDevolucion (DevolverEN devolver);

void ModificarDevolucion (DevolverEN devolver);


void BorrarDevolucion (int id
                       );
}
}
