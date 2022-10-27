
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_generarCodigoLocalizacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class PedidoCEN
{
public void GenerarCodigoLocalizacion (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_generarCodigoLocalizacion) ENABLED START*/

        // Write here your custom code...
        PedidoCEN ped1 = new PedidoCEN ();
        PedidoEN pedEN = ped1.DamePedidoOID (p_oid);

        if (pedEN.Estado == Enumerated.UltrAthletics.EstadoPedidoEnum.carrito) {
                throw new Exception ();
        }

        string charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] caracteres = new char [12];
        Random random = new Random ();

        for (int i = 0; i < caracteres.Length; i++) {
                caracteres [i] = charset [random.Next (charset.Length)];
        }

        string generada = new string(caracteres);

        pedEN.Seguimiento = generada;
        _IPedidoCAD.ModificarPedido (pedEN);

        /*PROTECTED REGION END*/
}
}
}
