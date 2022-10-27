
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UltrAthleticsGenNHibernate.Exceptions;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Producto_incrementarStock) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class ProductoCEN
{
public void IncrementarStock (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Producto_incrementarStock) ENABLED START*/

        // Write here your custom code...
        ProductoCAD proCAD = new ProductoCAD ();

        if (cant < 0) {
                throw new Exception ("no se pueden a�adir cantidades negativas");
        }

        ProductoEN proEN = proCAD.DameProductoOID (p_oid);

        int x = proEN.Stock + cant;
        proEN.Stock = x;


        proCAD.ModifyDefault (proEN);

        /*PROTECTED REGION END*/
}
}
}
