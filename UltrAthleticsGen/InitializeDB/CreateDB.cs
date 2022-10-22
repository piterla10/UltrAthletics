
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
                // Insert the initilizations of entities using the CEN classes

                UsuarioCEN abel = new UsuarioCEN ();
                abel.CrearCuenta ("abel@prebombeo", "1234");

                if (abel.IniciarSesion ("abel@prebombeo", "1234") != null) {
                        Console.WriteLine ("INICIO DE SESION CORRECTO");
                }

                //CREACION DE PRODUCTOS

                ProductoCEN pro1 = new ProductoCEN ();
                int idpro1 = pro1.CrearProducto ("dildo", "grande", 100, 5, 0, "gigawia");
                ProductoCEN pro2 = new ProductoCEN ();
                int idpro2 = pro1.CrearProducto ("mancuerna", "small", 30, 2, 0, "sasdas");


                //CREACION DE PEDIDO
                PedidoCEN ped1 = new PedidoCEN ();
                int idped = ped1.CrearPedido ("13-12-1222", "calle secuestro123", "12355551231231", EstadoPedidoEnum.enCamino, "abel@prebombeo", 0);

                PedidoEN pedEN = ped1.ReadOID (idped);
                Console.WriteLine ("EL pedido");


                LineaPedidoCEN lin1 = new LineaPedidoCEN ();
                int idlin1 = lin1.CrearLinea (3, idped, 100, idpro1);

                LineaPedidoEN lin = lin1.ReadOID (idlin1);
                Console.WriteLine ("Linea 1 " + lin.Pedido.Id);

                LineaPedidoCEN lin2 = new LineaPedidoCEN ();
                int idlin2 = lin1.CrearLinea (1, idped, 30, idpro2);



                pedEN = ped1.ReadOID (idped);
                Console.WriteLine ("EL pedido tiene el total");



                // PedidoEN ped = ped1.ReadOID(idped);

                //IList<LineaPedidoEN> listalienas = lin1.VerLineasPorPedido (lin.Pedido.Id);
                IList<LineaPedidoEN> listalienas = lin1.VerLineasPorPedido (idped);
                int x = 1;
                Console.WriteLine ("Lineas del pedido ");
                foreach (LineaPedidoEN lon in listalienas) {
                        Console.WriteLine ("Linea " + x + " " + lon.Id + " "+ lon.Pedido.Id);
                   
                        x++;
                }


                ped1.GetTotal(idped);



                // p.e. CustomerCEN customer = new CustomerCEN();
                // customer.New_ (p_user:"user", p_password:"1234");



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
