using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            #region SqlConn
            /*connectionString = "Server = DESKTOP-Q61IKQ5; Database = Troya; Trusted_Connection = True;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;

            try
            {
                connection.Open();
                Console.WriteLine("Openned Db");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Select * from CAR";
            *//*    int rdrnq = cmd.ExecuteNonQuery();*//*
                
                

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[1]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback();

            }
            finally { connection.Close(); Console.WriteLine("Connection Close"); }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Подключение oткрыто");
                Console.WriteLine("Свойство подключения: ");
                Console.WriteLine("Строка подключения: {0}", con.ConnectionString);
                Console.WriteLine("База данных: {0}", con.DataSource);
                Console.WriteLine("Сервер: {0}", con.ServerVersion);
                Console.WriteLine("Версия сервера: {0}", con.State);
                Console.WriteLine("Время ожидания: ", con.ConnectionTimeout);
            }
            Console.WriteLine("Подключение закрыто");*/
            #endregion

            #region OleDbConnection
            //connectionString = "Provider=MSOLEDBSQL; Server=DESKTOP-Q61IKQ5; Database=Troya; Trusted_Connection=yes;"
            /* connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionOleDb"].ConnectionString;

             using (OleDbConnection conn = new OleDbConnection(connectionString))
             {
                 conn.Open();
                 Console.WriteLine("Подключение oткрыто");
                 Console.WriteLine("Свойство подключения: ");
                 Console.WriteLine("Строка подключения: {0}", conn.ConnectionString);
                 Console.WriteLine("База данных: {0}", conn.DataSource);
                 Console.WriteLine("Сервер: {0}", conn.ServerVersion);
                 Console.WriteLine("Версия сервера: {0}", conn.State);
                 Console.WriteLine("Время ожидания: ", conn.ConnectionTimeout);
                 conn.Close();
                 Console.WriteLine("Connection closed");
             }*/

            #endregion

            #region Odbc conn
            // connectionString = "Driver={ODBC Driver 17 for SQL Server};Server=DESKTOP-Q61IKQ5;Database=Troya;Trusted_Connection=yes;";
            /*connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnectionsOdbc"]
                .ConnectionString;
            using (OdbcConnection con = new OdbcConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Подключение oткрыто");
                Console.WriteLine("Свойство подключения: ");
                Console.WriteLine("Строка подключения: {0}", con.ConnectionString);
                Console.WriteLine("База данных: {0}", con.DataSource);
                Console.WriteLine("Сервер: {0}", con.State);
                Console.WriteLine("Версия сервера: {0}", con.ServerVersion);
                Console.WriteLine("Время ожидания: ", con.ConnectionTimeout);
                con.Close();
                Console.WriteLine("Connection closed");
            }*/
            #endregion

            #region Oracle Conn
            //connectionString = "Data Source=MyOracleDB;Integrated Security=yes;"
            connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnectionsOracle"]
                .ConnectionString;
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Подключение oткрыто");
                Console.WriteLine("Свойство подключения: ");
                Console.WriteLine("Строка подключения: {0}", con.ConnectionString);
                Console.WriteLine("База данных: {0}", con.DataSource);
                Console.WriteLine("Сервер: {0}", con.State);
                Console.WriteLine("Версия сервера: {0}", con.ServerVersion);
                con.Close();
                Console.WriteLine("Connection closed");
            }
            #endregion
        }
    }
}
