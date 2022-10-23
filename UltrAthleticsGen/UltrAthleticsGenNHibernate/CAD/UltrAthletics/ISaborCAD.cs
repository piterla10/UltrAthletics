
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface ISaborCAD
{
SaborEN ReadOIDDefault (string nombre
                        );

void ModifyDefault (SaborEN sabor);

System.Collections.Generic.IList<SaborEN> ReadAllDefault (int first, int size);



string CrearSabor (SaborEN sabor);

void ModificarSabor (SaborEN sabor);


void BorrarSabor (string nombre
                  );


SaborEN DaneSaborOID (string nombre
                      );


System.Collections.Generic.IList<SaborEN> DameSaborTodos (int first, int size);
}
}
