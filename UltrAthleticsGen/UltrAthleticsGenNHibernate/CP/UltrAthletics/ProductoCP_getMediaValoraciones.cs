
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



/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CP.UltrAthletics_Producto_getMediaValoraciones) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CP.UltrAthletics
{
public partial class ProductoCP : BasicCP
{
public float GetMediaValoraciones (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CP.UltrAthletics_Producto_getMediaValoraciones) ENABLED START*/

        IProductoCAD productoCAD = null;
        ProductoCEN productoCEN = null;

        float result = 0;


        try
        {
                SessionInitializeTransaction ();
                productoCAD = new ProductoCAD (session);
                productoCEN = new  ProductoCEN (productoCAD);
                int k = 0;

                //precondicion
                ProductoEN pro = productoCAD.DameProductoOID(p_oid);
                if (pro == null) { throw new Exception("El producto no existe"); }

                IList<ValoracionEN> valoraciones = pro.Valoracion;

                if (valoraciones.Count != 0)
                {
                    foreach (ValoracionEN val in valoraciones)
                    {
                        result += val.Valor;
                        k++;
                    }

                    result = result / k;
                }


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
