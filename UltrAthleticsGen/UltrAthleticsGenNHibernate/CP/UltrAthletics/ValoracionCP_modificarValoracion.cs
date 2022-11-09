
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



/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CP.UltrAthletics_Valoracion_modificarValoracion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CP.UltrAthletics
{
public partial class ValoracionCP : BasicCP
{
public void ModificarValoracion (int p_Valoracion_OID, string p_comentario, int p_valor)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CP.UltrAthletics_Valoracion_modificarValoracion) ENABLED START*/

        IValoracionCAD valoracionCAD = null;
        ValoracionCEN valoracionCEN = null;

        IProductoCAD productoCAD = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionCAD = new ValoracionCAD (session);
                valoracionCEN = new  ValoracionCEN (valoracionCAD);
                productoCAD = new ProductoCAD (session);
                ValoracionEN valoracionEN = null;
                ValoracionEN actual = valoracionCAD.DameValoracionOID (p_Valoracion_OID);



                //Modificar total y media de valoraciones del producto
                ProductoEN producto = actual.Producto;

                producto.MediaValoracion = (producto.MediaValoracion * (producto.TotalValoracion) - actual.Valor + p_valor) / producto.TotalValoracion;
                productoCAD.ModificarProducto (producto);



                //Initialized ValoracionEN
                valoracionEN = new ValoracionEN ();
                valoracionEN.Id = p_Valoracion_OID;
                valoracionEN.Comentario = p_comentario;
                valoracionEN.Valor = p_valor;
                //Call to ValoracionCAD

                valoracionCAD.ModificarValoracion (valoracionEN);


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


        /*PROTECTED REGION END*/
}
}
}
