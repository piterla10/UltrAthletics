
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


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_getCodigoDevolucion) ENABLED START*/
//  references to other libraries
using IronBarCode;
using System.IO;
using System.Drawing;
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class PedidoCEN
{
public string GetCodigoDevolucion (int p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Pedido_getCodigoDevolucion) ENABLED START*/

        // Write here your custom code...

        PedidoCEN ped1 = new PedidoCEN ();
        PedidoEN pedEN = ped1.DamePedidoOID (p_oid);

        if (pedEN.Estado != Enumerated.UltrAthletics.EstadoPedidoEnum.entregado) {
                throw new Exception ();
        }

        Image barritas = BarcodeWriter.CreateBarcode (p_oid.ToString (), BarcodeWriterEncoding.Code128).Image;

        MemoryStream memoria = new MemoryStream ();

        barritas.Save (memoria, barritas.RawFormat);

        FileStream fs = new FileStream (p_oid + ".jpg", FileMode.Create, FileAccess.Write);

        byte[] bytes = memoria.ToArray ();

        fs.Write (bytes, 0, bytes.Length);

        return p_oid + ".jpg";

        /*PROTECTED REGION END*/
}
}
}
