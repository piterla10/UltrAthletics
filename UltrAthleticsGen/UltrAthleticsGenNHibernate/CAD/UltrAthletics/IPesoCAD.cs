
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface IPesoCAD
{
PesoEN ReadOIDDefault (string cantidad
                       );

void ModifyDefault (PesoEN peso);

System.Collections.Generic.IList<PesoEN> ReadAllDefault (int first, int size);



string CrearPeso (PesoEN peso);

void ModificarPeso (PesoEN peso);


void BorrarPeso (string cantidad
                 );


PesoEN DamePesoOID (string cantidad
                    );


System.Collections.Generic.IList<PesoEN> DamePesoTodos (int first, int size);
}
}
