
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CEN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;
using UltrAthleticsGenNHibernate.Enumerated.UltrAthletics;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                //INICIALIZACI�N

                UsuarioCEN usuarioCEN = new UsuarioCEN ();
                ProductoCEN pro = new ProductoCEN ();

                //CREACI�N
                usuarioCEN.CrearUsuario ("usuarioCEN@correo", "1234", RolesEnum.admin);
                UsuarioEN usuarioEN = new UsuarioEN ();
                usuarioEN = usuarioCEN.DameUsuarioOID ("usuarioCEN@correo");

                ProductoEN pro1EN = new ProductoEN ();

                //abel.RecuperarContrasenya ("abel@prebombeo");

                if (usuarioCEN.IniciarSesion ("usuarioCEN@correo", "1234") != null) {
                        Console.WriteLine ("INICIO DE SESION CORRECTO");
                }

                //CREACION DE PRODUCTOS
                int idpro1 = pro.CrearProducto ("proteina", "grande", 100, 5, 0, null,0);
                pro1EN = pro.DameProductoOID (idpro1);

                ProductoEN pro2EN = new ProductoEN ();
                int idpro2 = pro.CrearProducto ("mancuerna", "pequeña", 30, 2, 0, null,0);
                pro2EN = pro.DameProductoOID (idpro2);

                // Console.WriteLine("Producto : " + pro1EN.Nombre + " Stock " + pro1EN.Stock);
                pro.DecrementarStock (idpro1, 3);
                pro1EN = pro.DameProductoOID (idpro1);
                // Console.WriteLine("Producto : " + pro1EN.Nombre + " Stock " + pro1EN.Stock);

                CategoriaCEN catCen = new CategoriaCEN ();
                CategoriaEN catEn = new CategoriaEN ();
                catEn = catCen.DameCategoriaOID (catCen.CrearCategoria ("natación", "deportes de natación"));
                pro.AsignarCategoria (idpro1, new List<String>{ "natación" });
                pro.AsignarCategoria (idpro2, new List<String> { "natación" });

                Random rdn = new Random ();
                string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
                int longitud = caracteres.Length;
                char letra;
                int longitudContrasenia = 10;
                string nuevopass = string.Empty;
                for (int i = 0; i < longitudContrasenia; i++) {
                        letra = caracteres [rdn.Next (longitud)];
                        nuevopass += letra.ToString ();
                }

                Console.WriteLine (nuevopass);

                //uso calcular macronutrientes
                usuarioCEN.CalcularMacronutrientes (EstiloVidaEnum.fuerte, ObjetivosEnum.volumen, 92, 180, SexoEnum.hombre, "usuarioCEN@correo", 21);


                //anyadienco productos a deseados
                usuarioCEN.AnyadirDeseado ("usuarioCEN@correo", new List<int> { idpro1, idpro2 });

                //usuarioCEN.DameDeseados ("usuarioCEN@correo");






                /*
                 * IList<ProductoEN> lsta = pro1.DameProductoPorCategoria (catEn.Nombre);
                 *
                 * foreach (ProductoEN pro in lsta) {
                 *      Console.WriteLine ("***********************************");
                 *
                 *      Console.WriteLine ("Producto : " + pro.Nombre);
                 *
                 *      Console.WriteLine ("***********************************");
                 * }
                 */
                // abel.RecuperarContrasenya("abel@prebombeo");






                /*
                 * //CREACION DE PEDIDO
                 * PedidoCEN ped1 = new PedidoCEN ();
                 * int idped = ped1.CrearPedido ("13-12-1222", "calle gooku", "12355551231231", EstadoPedidoEnum.enCamino, "abel@prebombeo", 0.3);
                 *
                 * PedidoEN pedEN = ped1.DamePedidoOID (idped);
                 * // Console.WriteLine ("EL pedido");
                 *
                 *
                 * LineaPedidoCEN lin1 = new LineaPedidoCEN ();
                 * int idlin1 = lin1.CrearLinea (3, idped, 50, idpro1);
                 *
                 * LineaPedidoEN lin = lin1.DameLineaPedidoOID (idlin1);
                 * //Console.WriteLine ("Linea 1 " + lin.Pedido.Id);
                 *
                 * LineaPedidoCEN lin2 = new LineaPedidoCEN ();
                 * int idlin2 = lin1.CrearLinea (1, idped, 15, idpro2);
                 *
                 *
                 *
                 * pedEN = ped1.DamePedidoOID (idped);
                 * // Console.WriteLine ("EL pedido tiene el total");
                 *
                 *
                 *
                 * // PedidoEN ped = ped1.DamePedidoOID(idped);
                 * /*
                 * //IList<LineaPedidoEN> listalienas = lin1.VerLineasPorPedido (lin.Pedido.Id);
                 * IList<LineaPedidoEN> listalienas = lin1.VerLineasPorPedido (idped);
                 * int x = 1;
                 * Console.WriteLine ("Lineas del pedido ");
                 * foreach (LineaPedidoEN lon in listalienas) {
                 *      Console.WriteLine ("Linea " + x + " " + lon.Id + " " + lon.Pedido.Id);
                 *
                 *      x++;
                 * }
                 *
                 */

                //lin1.GetTotalLinea (idlin1);
                //ped1.GetTotal (idped);

                /*
                 * IList<PedidoEN> listaPedEN = ped1.DamePedidoUsuario("abel@prebombeo");
                 * int y = 1;
                 * Console.WriteLine ("pedidos de "+abelEN.Email);
                 * foreach (PedidoEN ped in listaPedEN)
                 * {
                 *   Console.WriteLine ("Pedido " + y + " " + ped.Id);
                 *   Console.WriteLine("***********************************");
                 *
                 *  ped1.GetTotal(ped.Id);
                 *
                 *  Console.WriteLine("***********************************");
                 *  y++;
                 * }
                 */



                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
