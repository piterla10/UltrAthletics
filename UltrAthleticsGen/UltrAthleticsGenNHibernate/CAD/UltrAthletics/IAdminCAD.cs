
using System;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthleticsGenNHibernate.CAD.UltrAthletics
{
public partial interface IAdminCAD
{
AdminEN ReadOIDDefault (string email
                        );

void ModifyDefault (AdminEN admin);

System.Collections.Generic.IList<AdminEN> ReadAllDefault (int first, int size);



string CrearAdmin (AdminEN admin);

void ModificarAdmin (AdminEN admin);


void Borrar (string email
             );


AdminEN ReadOID (string email
                 );


System.Collections.Generic.IList<AdminEN> ReadAll (int first, int size);
}
}
