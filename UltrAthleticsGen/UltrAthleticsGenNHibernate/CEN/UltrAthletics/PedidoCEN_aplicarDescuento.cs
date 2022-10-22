
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_aplicarDescuento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class PedidoCEN
{
public double AplicarDescuento (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_aplicarDescuento) ENABLED START*/

        PedidoCEN ped1 = new PedidoCEN ();

        //PRECONDICIONES

        if (p_oid == null)
                throw new Exception ("Ningun pedido proporcionado");

        if (ped1.ReadOID (p_oid) == null)
                throw new Exception ("El pedido " + p_oid + " no existe");

        PedidoEN pedEN = ped1.ReadOID (p_oid);

        if (pedEN.Descuento == 0)
                throw new Exception ("DESCUENTO NO APLICABLE");

        double total = 0;
        double descontar = 0;
        float aux = 0;
        aux = ped1.GetTotal (p_oid);
        descontar = aux * pedEN.Descuento;
        total =  aux-descontar;

            Console.WriteLine(" DESCUENTO: " + pedEN.Descuento*100);

            Console.WriteLine ("PRECIO TOTAL CON DESCUENTO: " + total);

        return total;

        if (total == 0)
                throw new NotImplementedException ("Method AplicarDescuento() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
