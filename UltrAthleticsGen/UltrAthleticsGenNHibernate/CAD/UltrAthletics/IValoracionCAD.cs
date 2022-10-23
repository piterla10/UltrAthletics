
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



int CrearValoracion (ValoracionEN valoracion);

void ModificarValoracion (ValoracionEN valoracion);


void BorrarValoracion (int id
                       );


ValoracionEN DameValoracionOID (int id
                                );


System.Collections.Generic.IList<ValoracionEN> DameValoracionTodos (int first, int size);
}
}
