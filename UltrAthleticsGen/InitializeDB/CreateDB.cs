
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CEN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;
using UltrAthleticsGenNHibernate.CP.UltrAthletics;
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
                //creando objetos CEN
                UsuarioCEN usuarioCEN = new UsuarioCEN ();
                ProductoCEN productoCEN = new ProductoCEN ();
                ValoracionCEN valoracionCEN = new ValoracionCEN ();
                PedidoCEN pedidoCEN = new PedidoCEN ();
                LineaPedidoCEN lineaPedidoCEN = new LineaPedidoCEN ();
                CategoriaCEN categoriaCEN = new CategoriaCEN ();


                //creamos todos los objetos CP
                ProductoCP productoCP = new ProductoCP ();
                UsuarioCP usuarioCP = new UsuarioCP ();

                //creando usuarios
                String idUsuario = usuarioCEN.CrearUsuario ("usuarioCEN@correo", "1234", RolesEnum.admin);
                String idJuan = usuarioCEN.CrearUsuario ("juan@correo", "1234", RolesEnum.cliente);

                UsuarioEN usuarioEN = new UsuarioEN ();
                usuarioEN = usuarioCEN.DameUsuarioOID (idUsuario);

                UsuarioEN juanEN = new UsuarioEN ();
                juanEN = usuarioCEN.DameUsuarioOID (idJuan);


                //Creando pedidos
                int idped = pedidoCEN.CrearPedido (EstadoPedidoEnum.carrito, "usuarioCEN@correo");
                PedidoEN pedEN = pedidoCEN.DamePedidoOID (idped);




                //Creando productos
                ProductoEN pro1EN = new ProductoEN ();
                int idpro1 = productoCEN.CrearProducto ("proteina", "grande", 100, 5, 0, null, 0);
                pro1EN = productoCEN.DameProductoOID (idpro1);

                ProductoEN pro2EN = new ProductoEN ();
                int idpro2 = productoCEN.CrearProducto ("mancuerna", "pequeña", 30, 2, 0, null, 0);
                pro2EN = productoCEN.DameProductoOID (idpro2);


                //creando lineas de pedido
                int idLinea1 = lineaPedidoCEN.CrearLinea (3, idped, 50, idpro1);
                LineaPedidoEN linea1EN = lineaPedidoCEN.DameLineaPedidoOID (idLinea1);
                int idLinea2 = lineaPedidoCEN.CrearLinea (1, idped, 15, idpro2);


                //creando valoraciones
                valoracionCEN.CrearValoracion ("muy bueno", 4, idUsuario, idpro1);
                valoracionCEN.CrearValoracion ("perfecto", 5, idJuan, idpro1);
                valoracionCEN.CrearValoracion("uma delisia", 5, "usuarioCEN@correo", idpro1);
                valoracionCEN.CrearValoracion("uma delisia", 10, "usuarioCEN@correo", idpro1);


                //creamos una categoria
                CategoriaEN categoriaEN = new CategoriaEN ();
                String idCategoria1 = categoriaCEN.CrearCategoria ("natación", "deportes de natación");
                categoriaEN = categoriaCEN.DameCategoriaOID (idCategoria1);


                //probamos el inicio de sesion
                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos si se inicia sesion con el usuairo " + usuarioEN.Email);
                if (usuarioCEN.IniciarSesion ("usuarioCEN@correo", "1234") != null) {
                        Console.WriteLine ("Inicio de sesion correcto");
                }


                //probamos el total de las valoraciones
                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo getTotalValoraciones");
                pro1EN = productoCEN.DameProductoOID (idpro1);
                Console.WriteLine ("producto: " + pro1EN.Id + " " + pro1EN.Nombre);
                Console.WriteLine ("Total valoraciones: " + productoCP.GetTotalValoraciones (idpro1));


                //decrementas el stock
                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo decrementarStock y incrementarStock");

                Console.WriteLine ("Producto: " + pro1EN.Nombre + " Stock inicial " + pro1EN.Stock);
                productoCEN.DecrementarStock (idpro1, 3);
                pro1EN = productoCEN.DameProductoOID (idpro1);
                Console.WriteLine ("Producto : " + pro1EN.Nombre + " Stock decrementado (le hemos quitado 3) " + pro1EN.Stock);

                productoCEN.IncrementarStock (idpro1, 6);
                pro1EN = productoCEN.DameProductoOID (idpro1);
                Console.WriteLine ("Producto : " + pro1EN.Nombre + " Stock incrementado (le hemos incrementado en 6) " + pro1EN.Stock);

                //Probamos asignar categoria y los productos relacionados a esa categoria
                productoCEN.AsignarCategoria (idpro1, new List<String>{ "natación" });
                productoCEN.AsignarCategoria (idpro2, new List<String> { "natación" });

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo DameProductoPorCategoria con la categoria: " + categoriaEN.Nombre);
                IList<ProductoEN> lsta = productoCEN.DameProductoPorCategoria (categoriaEN.Nombre);
                foreach (ProductoEN pro in lsta) {
                        Console.WriteLine ("Producto : " + pro.Nombre);
                }

                //uso calcular macronutrientes
                Console.WriteLine ("***********************************");
                Console.WriteLine ("Pruebo el metodo calcularMacronutrientes");
                usuarioCEN.CalcularMacronutrientes (EstiloVidaEnum.fuerte, ObjetivosEnum.volumen, 92, 180, SexoEnum.hombre, "usuarioCEN@correo", 21);


                //anyadienco productos a deseados y los mostramos por pantalla
                usuarioCEN.AnyadirDeseado ("usuarioCEN@correo", new List<int> { idpro1, idpro2 });

                /*
                 * Console.WriteLine("***********************************");
                 * Console.WriteLine("Probamos el metodo dameDeseados para el usuario " + usuarioEN.Email);
                 * IList<ProductoEN> listDeseados =  usuarioCP.DameDeseados(idUsuario);
                 * foreach (ProductoEN pro in listDeseados)
                 * {
                 * Console.WriteLine("Producto : " + pro.Nombre);
                 * }
                 */

                //probamos el metodo para RecuperarContrasenya
                //Console.WriteLine("***********************************");
                //usuarioCEN.RecuperarContrasenya(idUsuario);


                pedEN = pedidoCEN.DamePedidoOID (idped);

                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo VerLineasPorPedido");
                IList<LineaPedidoEN> listalienas = lineaPedidoCEN.VerLineasPorPedido (idped);
                int x = 1;
                Console.WriteLine ("Lineas del pedido ");
                foreach (LineaPedidoEN lon in listalienas) {
                        Console.WriteLine ("Linea " + x + " " + lon.Id + " " + lon.Pedido.Id);

                        x++;
                }


                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo GetTotal del pedido anterior ");
                pedidoCEN.GetTotal (idped);


                Console.WriteLine ("***********************************");
                Console.WriteLine ("Probamos el metodo DamePedidoUsuario ");
                IList<PedidoEN> listaPedEN = pedidoCEN.DamePedidoUsuario (idUsuario);
                int y = 1;
                Console.WriteLine ("pedidos de " + usuarioEN.Email);
                foreach (PedidoEN ped in listaPedEN) {
                        Console.WriteLine ("Pedido " + y + " " + ped.Id);
                        y++;
                }

                Console.WriteLine ("***********************************");
                Console.WriteLine ("El estado inicial del pedido es" + pedEN.Estado);

                Console.WriteLine ("Probamos el metodo PagarPedido ");
                pedidoCEN.PagarPedido (idped);
                pedEN = pedidoCEN.DamePedidoOID (idped);
                Console.WriteLine ("El estado actual del pedido es: " + pedEN.Estado);

                Console.WriteLine ("Probamos el metodo EnviarPedido ");
                pedidoCEN.EnviarPedido (idped);
                pedEN = pedidoCEN.DamePedidoOID (idped);
                Console.WriteLine ("El estado actual del pedido: " + pedEN.Estado);

                Console.WriteLine ("Probamos el metodo EntregarPedido ");
                pedidoCEN.EntregarPedido (idped);
                pedEN = pedidoCEN.DamePedidoOID (idped);
                Console.WriteLine ("El estado actual del pedido es: " + pedEN.Estado);

                Console.WriteLine("***********************************");
                Console.WriteLine("Probamos el metodo GetMediaValoraciones");
                Console.WriteLine("Media de valoraciones:");
                Console.WriteLine(productoCP.GetMediaValoraciones(idpro1));

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
