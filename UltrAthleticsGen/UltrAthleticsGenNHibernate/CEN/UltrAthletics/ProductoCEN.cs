

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UltrAthleticsGenNHibernate.Exceptions;

using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;


namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
/*
 *      Definition of the class ProductoCEN
 *
 */
public partial class ProductoCEN
{
private IProductoCAD _IProductoCAD;

public ProductoCEN()
{
        this._IProductoCAD = new ProductoCAD ();
}

public ProductoCEN(IProductoCAD _IProductoCAD)
{
        this._IProductoCAD = _IProductoCAD;
}

public IProductoCAD get_IProductoCAD ()
{
        return this._IProductoCAD;
}

public ProductoEN DameProductoOID (int id
                                   )
{
        ProductoEN productoEN = null;

        productoEN = _IProductoCAD.DameProductoOID (id);
        return productoEN;
}

public System.Collections.Generic.IList<ProductoEN> DameProductoTodos (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> list = null;

        list = _IProductoCAD.DameProductoTodos (first, size);
        return list;
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorFiltro (string articulo)
{
        return _IProductoCAD.DameProductoPorFiltro (articulo);
}
public int CrearProducto (string p_nombre, string p_descripcion, float p_precio, int p_stock, float p_descuento, System.Collections.Generic.IList<string> p_imagen)
{
        ProductoEN productoEN = null;
        int oid;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Nombre = p_nombre;

        productoEN.Descripcion = p_descripcion;

        productoEN.Precio = p_precio;

        productoEN.Stock = p_stock;

        productoEN.Descuento = p_descuento;

        productoEN.Imagen = p_imagen;

        //Call to ProductoCAD

        oid = _IProductoCAD.CrearProducto (productoEN);
        return oid;
}

public void ModificarProducto (int p_Producto_OID, string p_nombre, string p_descripcion, float p_precio, int p_stock, float p_descuento, System.Collections.Generic.IList<string> p_imagen)
{
        ProductoEN productoEN = null;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Id = p_Producto_OID;
        productoEN.Nombre = p_nombre;
        productoEN.Descripcion = p_descripcion;
        productoEN.Precio = p_precio;
        productoEN.Stock = p_stock;
        productoEN.Descuento = p_descuento;
        productoEN.Imagen = p_imagen;
        //Call to ProductoCAD

        _IProductoCAD.ModificarProducto (productoEN);
}

public void BorrarProducto (int id
                            )
{
        _IProductoCAD.BorrarProducto (id);
}

public void AsignarCategoria (int p_Producto_OID, System.Collections.Generic.IList<string> p_categoria_OIDs)
{
        //Call to ProductoCAD

        _IProductoCAD.AsignarCategoria (p_Producto_OID, p_categoria_OIDs);
}
public void DesasignarCategoria (int p_Producto_OID, System.Collections.Generic.IList<string> p_categoria_OIDs)
{
        //Call to ProductoCAD

        _IProductoCAD.DesasignarCategoria (p_Producto_OID, p_categoria_OIDs);
}
public void AnyadirPeso (int p_Producto_OID, System.Collections.Generic.IList<string> p_peso_OIDs)
{
        //Call to ProductoCAD

        _IProductoCAD.AnyadirPeso (p_Producto_OID, p_peso_OIDs);
}
public void AnyadirSabor (int p_Producto_OID, System.Collections.Generic.IList<string> p_sabor_OIDs)
{
        //Call to ProductoCAD

        _IProductoCAD.AnyadirSabor (p_Producto_OID, p_sabor_OIDs);
}
public void EliminarPeso (int p_Producto_OID, System.Collections.Generic.IList<string> p_peso_OIDs)
{
        //Call to ProductoCAD

        _IProductoCAD.EliminarPeso (p_Producto_OID, p_peso_OIDs);
}
public void EliminarSabor (int p_Producto_OID, System.Collections.Generic.IList<string> p_sabor_OIDs)
{
        //Call to ProductoCAD

        _IProductoCAD.EliminarSabor (p_Producto_OID, p_sabor_OIDs);
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorCategoria (string categoria)
{
        return _IProductoCAD.DameProductoPorCategoria (categoria);
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorSabor (string sabo)
{
        return _IProductoCAD.DameProductoPorSabor (sabo);
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorPeso (string peso)
{
        return _IProductoCAD.DameProductoPorPeso (peso);
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorPrecio (int? maximo, int ? minimo)
{
        return _IProductoCAD.DameProductoPorPrecio (maximo, minimo);
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameDeseadosPorUsuario (string user)
{
        return _IProductoCAD.DameDeseadosPorUsuario (user);
}
}
}
