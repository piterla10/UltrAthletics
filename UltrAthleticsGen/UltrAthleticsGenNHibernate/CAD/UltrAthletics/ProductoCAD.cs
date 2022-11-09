
using System;
using System.Text;
using UltrAthleticsGenNHibernate.CEN.UltrAthletics;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.Exceptions;


/*
 * Clase Producto:
 *
 */

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial class ProductoCAD : BasicCAD, IProductoCAD
{
public ProductoCAD() : base ()
{
}

public ProductoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProductoEN ReadOIDDefault (int id
                                  )
{
        ProductoEN productoEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Get (typeof(ProductoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoEN;
}

public System.Collections.Generic.IList<ProductoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ProductoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ProductoEN>();
                        else
                                result = session.CreateCriteria (typeof(ProductoEN)).List<ProductoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), producto.Id);

                productoEN.Nombre = producto.Nombre;


                productoEN.Descripcion = producto.Descripcion;


                productoEN.Precio = producto.Precio;


                productoEN.Stock = producto.Stock;


                productoEN.Descuento = producto.Descuento;


                productoEN.Imagen = producto.Imagen;








                productoEN.MediaValoracion = producto.MediaValoracion;


                productoEN.TotalValoracion = producto.TotalValoracion;

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


//Sin e: DameProductoOID
//Con e: ProductoEN
public ProductoEN DameProductoOID (int id
                                   )
{
        ProductoEN productoEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Get (typeof(ProductoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoEN;
}

public System.Collections.Generic.IList<ProductoEN> DameProductoTodos (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProductoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProductoEN>();
                else
                        result = session.CreateCriteria (typeof(ProductoEN)).List<ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorFiltro (string articulo)
{
        System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where FROM ProductoEN as pro WHERE pro.Nombre = :articulo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENdameProductoPorFiltroHQL");
                query.SetParameter ("articulo", articulo);

                result = query.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public int CrearProducto (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (producto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return producto.Id;
}

public void ModificarProducto (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), producto.Id);

                productoEN.Nombre = producto.Nombre;


                productoEN.Descripcion = producto.Descripcion;


                productoEN.Precio = producto.Precio;


                productoEN.Stock = producto.Stock;


                productoEN.Descuento = producto.Descuento;


                productoEN.Imagen = producto.Imagen;

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarProducto (int id
                            )
{
        try
        {
                SessionInitializeTransaction ();
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), id);
                session.Delete (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AsignarCategoria (int p_Producto_OID, System.Collections.Generic.IList<string> p_categoria_OIDs)
{
        UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN productoEN = null;
        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Load (typeof(ProductoEN), p_Producto_OID);
                UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN categoriaENAux = null;
                if (productoEN.Categoria == null) {
                        productoEN.Categoria = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN>();
                }

                foreach (string item in p_categoria_OIDs) {
                        categoriaENAux = new UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN ();
                        categoriaENAux = (UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN), item);
                        categoriaENAux.Producto.Add (productoEN);

                        productoEN.Categoria.Add (categoriaENAux);
                }


                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void DesasignarCategoria (int p_Producto_OID, System.Collections.Generic.IList<string> p_categoria_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN productoEN = null;
                productoEN = (ProductoEN)session.Load (typeof(ProductoEN), p_Producto_OID);

                UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN categoriaENAux = null;
                if (productoEN.Categoria != null) {
                        foreach (string item in p_categoria_OIDs) {
                                categoriaENAux = (UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.CategoriaEN), item);
                                if (productoEN.Categoria.Contains (categoriaENAux) == true) {
                                        productoEN.Categoria.Remove (categoriaENAux);
                                        categoriaENAux.Producto.Remove (productoEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_categoria_OIDs you are trying to unrelationer, doesn't exist in ProductoEN");
                        }
                }

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void AnyadirPeso (int p_Producto_OID, System.Collections.Generic.IList<string> p_peso_OIDs)
{
        UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN productoEN = null;
        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Load (typeof(ProductoEN), p_Producto_OID);
                UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN pesoENAux = null;
                if (productoEN.Peso == null) {
                        productoEN.Peso = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN>();
                }

                foreach (string item in p_peso_OIDs) {
                        pesoENAux = new UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN ();
                        pesoENAux = (UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN), item);
                        pesoENAux.Producto.Add (productoEN);

                        productoEN.Peso.Add (pesoENAux);
                }


                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AnyadirSabor (int p_Producto_OID, System.Collections.Generic.IList<string> p_sabor_OIDs)
{
        UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN productoEN = null;
        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Load (typeof(ProductoEN), p_Producto_OID);
                UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN saborENAux = null;
                if (productoEN.Sabor == null) {
                        productoEN.Sabor = new System.Collections.Generic.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN>();
                }

                foreach (string item in p_sabor_OIDs) {
                        saborENAux = new UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN ();
                        saborENAux = (UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN), item);
                        saborENAux.Producto.Add (productoEN);

                        productoEN.Sabor.Add (saborENAux);
                }


                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void EliminarPeso (int p_Producto_OID, System.Collections.Generic.IList<string> p_peso_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN productoEN = null;
                productoEN = (ProductoEN)session.Load (typeof(ProductoEN), p_Producto_OID);

                UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN pesoENAux = null;
                if (productoEN.Peso != null) {
                        foreach (string item in p_peso_OIDs) {
                                pesoENAux = (UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.PesoEN), item);
                                if (productoEN.Peso.Contains (pesoENAux) == true) {
                                        productoEN.Peso.Remove (pesoENAux);
                                        pesoENAux.Producto.Remove (productoEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_peso_OIDs you are trying to unrelationer, doesn't exist in ProductoEN");
                        }
                }

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void EliminarSabor (int p_Producto_OID, System.Collections.Generic.IList<string> p_sabor_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN productoEN = null;
                productoEN = (ProductoEN)session.Load (typeof(ProductoEN), p_Producto_OID);

                UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN saborENAux = null;
                if (productoEN.Sabor != null) {
                        foreach (string item in p_sabor_OIDs) {
                                saborENAux = (UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN)session.Load (typeof(UltrAthleticsGenNHibernate.EN.UltrAthletics.SaborEN), item);
                                if (productoEN.Sabor.Contains (saborENAux) == true) {
                                        productoEN.Sabor.Remove (saborENAux);
                                        saborENAux.Producto.Remove (productoEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_sabor_OIDs you are trying to unrelationer, doesn't exist in ProductoEN");
                        }
                }

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorCategoria (string categoria)
{
        System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where SELECT pro FROM ProductoEN as pro INNER JOIN pro.Categoria as cat WHERE cat.Nombre = :categoria";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENdameProductoPorCategoriaHQL");
                query.SetParameter ("categoria", categoria);

                result = query.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorSabor (string sabo)
{
        System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where SELECT pro FROM ProductoEN as pro INNER JOIN pro.Sabor as sab WHERE sab.Nombre = :sabo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENdameProductoPorSaborHQL");
                query.SetParameter ("sabo", sabo);

                result = query.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> DameProductoPorPeso (string peso)
{
        System.Collections.Generic.IList<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where SELECT pro FROM ProductoEN as pro INNER JOIN pro.Peso as pes WHERE pes.Cantidad = :peso";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENdameProductoPorPesoHQL");
                query.SetParameter ("peso", peso);

                result = query.List<UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is UltrAthleticsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new UltrAthleticsGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
