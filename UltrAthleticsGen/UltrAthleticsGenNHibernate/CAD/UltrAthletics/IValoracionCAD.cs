
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface IValoracionCAD
{
ValoracionEN ReadOIDDefault (int id
                             );

void ModifyDefault (ValoracionEN valoracion);

System.Collections.Generic.IList<ValoracionEN> ReadAllDefault (int first, int size);



int Crear (ValoracionEN valoracion);

void Modificar (ValoracionEN valoracion);


void Destroy (int id
              );


ValoracionEN DameValoracionOID (int id
                                );


System.Collections.Generic.IList<ValoracionEN> DameTodosValoraciones (int first, int size);
}
}
