
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface IFacturaCAD
{
FacturaEN ReadOIDDefault (int id
                          );

void ModifyDefault (FacturaEN factura);

System.Collections.Generic.IList<FacturaEN> ReadAllDefault (int first, int size);



int CrearFactura (FacturaEN factura);

void ModificarFactura (FacturaEN factura);


void BorrarFactura (int id
                    );


FacturaEN DameFacturaOID (int id
                          );


System.Collections.Generic.IList<FacturaEN> DameFacturaTodos (int first, int size);
}
}
