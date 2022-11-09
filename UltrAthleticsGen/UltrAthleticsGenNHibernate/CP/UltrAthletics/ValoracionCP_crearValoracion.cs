
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;
using UltrAthleticsGenNHibernate.CEN.UltrAthletics;



/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CP.UltrAthletics_Valoracion_crearValoracion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CP.UltrAthletics
{
public partial class ValoracionCP : BasicCP
{
public UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN CrearValoracion (string p_comentario, int p_valor, string p_usuario, int p_producto)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CP.UltrAthletics_Valoracion_crearValoracion) ENABLED START*/

        IValoracionCAD valoracionCAD = null;
        ValoracionCEN valoracionCEN = null;

        IProductoCAD productoCAD = null;

        UltrAthleticsGenNHibernate.EN.UltrAthletics.ValoracionEN result = null;


        try
        {
                SessionInitializeTransaction ();
                valoracionCAD = new ValoracionCAD (session);
                valoracionCEN = new  ValoracionCEN (valoracionCAD);
                productoCAD = new ProductoCAD (session);




                int oid;
                //Initialized ValoracionEN
                ValoracionEN valoracionEN;
                valoracionEN = new ValoracionEN ();
                valoracionEN.Comentario = p_comentario;

                valoracionEN.Valor = p_valor;


                if (p_usuario != null) {
                        valoracionEN.Usuario = new UltrAthleticsGenNHibernate.EN.UltrAthletics.UsuarioEN ();
                        valoracionEN.Usuario.Email = p_usuario;
                }


                if (p_producto != -1) {
                        valoracionEN.Producto = new UltrAthleticsGenNHibernate.EN.UltrAthletics.ProductoEN ();
                        valoracionEN.Producto.Id = p_producto;
                }

                //Call to ValoracionCAD

                oid = valoracionCAD.CrearValoracion (valoracionEN);
                result = valoracionCAD.ReadOIDDefault (oid);

                //Modificar total y media de valoraciones del producto
                ProductoEN producto = productoCAD.ReadOIDDefault (p_producto);
                producto.TotalValoracion += 1;

                producto.MediaValoracion = (producto.MediaValoracion * (producto.TotalValoracion - 1) + p_valor) / producto.TotalValoracion;

                productoCAD.ModificarProducto (producto);



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
