
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface IProductoCAD
{
ProductoEN ReadOIDDefault (int id
                           );

void ModifyDefault (ProductoEN producto);

System.Collections.Generic.IList<ProductoEN> ReadAllDefault (int first, int size);






ProductoEN DameProductoOID (int id
                            );


System.Collections.Generic.IList<ProductoEN> DameTodos (int first, int size);


System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorFiltro ();


int CrearProducto (ProductoEN producto);

void Modify (ProductoEN producto);


void Destroy (int id
              );


void AsignarCategoria (int p_Producto_OID, System.Collections.Generic.IList<string> p_categoria_OIDs);

void DesasignarCategoria (int p_Producto_OID, System.Collections.Generic.IList<string> p_categoria_OIDs);
}
}
