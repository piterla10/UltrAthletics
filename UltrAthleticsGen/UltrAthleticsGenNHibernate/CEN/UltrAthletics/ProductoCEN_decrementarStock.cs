
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Producto_decrementarStock) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class ProductoCEN
{
public void DecrementarStock (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Producto_decrementarStock) ENABLED START*/

        // Write here your custom code...

        if (cant < 0) {
                throw new Exception ("no se pueden usar cantidades negativas");
        }

        ProductoEN proEN = _IProductoCAD.DameProductoOID (p_oid);

        if (cant > proEN.Stock) {
                throw new Exception ("no se pueden eliminar mas unidades de las que existen");
        }


        proEN.Stock -= cant;

        _IProductoCAD.ModifyDefault (proEN);



        /*PROTECTED REGION END*/
}
}
}
