
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



/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CP.UltrAthletics_Valoracion_borrarValoracion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CP.UltrAthletics
{
public partial class ValoracionCP : BasicCP
{
public void BorrarValoracion (int p_Valoracion_OID)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CP.UltrAthletics_Valoracion_borrarValoracion) ENABLED START*/

        IValoracionCAD valoracionCAD = null;
        ValoracionCEN valoracionCEN = null;
        ValoracionEN valoracionEN = null;

        IProductoCAD productoCAD = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionCAD = new ValoracionCAD (session);
                valoracionCEN = new  ValoracionCEN (valoracionCAD);
                valoracionEN = valoracionCAD.DameValoracionOID (p_Valoracion_OID);

                productoCAD = new ProductoCAD (session);

                //Modificar total y media de valoraciones del producto
                ProductoEN producto = valoracionEN.Producto;
                producto.TotalValoracion -= 1;

                producto.MediaValoracion = (producto.MediaValoracion * (producto.TotalValoracion + 1) - valoracionEN.Valor) / producto.TotalValoracion;

                productoCAD.ModificarProducto (producto);

                ProductoEN productoPrueba = productoCAD.DameProductoOID (valoracionEN.Producto.Id);

                valoracionCAD.BorrarValoracion (p_Valoracion_OID);


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
