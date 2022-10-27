
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface IDevolucionCAD
{
DevolucionEN ReadOIDDefault (int id
                             );

void ModifyDefault (DevolucionEN devolucion);

System.Collections.Generic.IList<DevolucionEN> ReadAllDefault (int first, int size);



int CrearDevolucion (DevolucionEN devolucion);

void ModificarDevolucion (DevolucionEN devolucion);


void BorrarDevolucion (int id
                       );


DevolucionEN DameDevolucionOID (int id
                                );


System.Collections.Generic.IList<DevolucionEN> DameTodosDevolucion (int first, int size);
}
}
