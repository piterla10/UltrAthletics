
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface ICategoriaCAD
{
CategoriaEN ReadOIDDefault (string nombre
                            );

void ModifyDefault (CategoriaEN categoria);

System.Collections.Generic.IList<CategoriaEN> ReadAllDefault (int first, int size);



string New_ (CategoriaEN categoria);

void Modify (CategoriaEN categoria);


void Destroy (string nombre
              );


CategoriaEN ReadOID (string nombre
                     );


System.Collections.Generic.IList<CategoriaEN> ReadAll (int first, int size);
}
}
