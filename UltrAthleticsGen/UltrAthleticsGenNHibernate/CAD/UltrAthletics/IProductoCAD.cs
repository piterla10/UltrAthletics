
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


System.Collections.Generic.IList<ProductoEN> DameProductoTodos (int first, int size);


System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorFiltro (string articulo);


int CrearProducto (ProductoEN producto);

void ModificarProducto (ProductoEN producto);


void BorrarProducto (int id
                     );


void AsignarCategoria (int p_Producto_OID, System.Collections.Generic.IList<string> p_categoria_OIDs);

void DesasignarCategoria (int p_Producto_OID, System.Collections.Generic.IList<string> p_categoria_OIDs);

void AnyadirPeso (int p_Producto_OID, System.Collections.Generic.IList<string> p_peso_OIDs);

void AnyadirSabor (int p_Producto_OID, System.Collections.Generic.IList<string> p_sabor_OIDs);

void EliminarPeso (int p_Producto_OID, System.Collections.Generic.IList<string> p_peso_OIDs);

void EliminarSabor (int p_Producto_OID, System.Collections.Generic.IList<string> p_sabor_OIDs);

System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorCategoria (string categoria);


System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorSabor (string sabo);


System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorPeso (string peso);
}
}
