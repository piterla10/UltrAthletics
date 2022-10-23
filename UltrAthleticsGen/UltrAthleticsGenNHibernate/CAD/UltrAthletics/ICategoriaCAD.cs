
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



string CrearCategoria (CategoriaEN categoria);

void ModificarCategoria (CategoriaEN categoria);


void BorrarCategoria (string nombre
                      );


CategoriaEN DameCategoriaOID (string nombre
                              );


System.Collections.Generic.IList<CategoriaEN> DameCategoriaTodos (int first, int size);
}
}
