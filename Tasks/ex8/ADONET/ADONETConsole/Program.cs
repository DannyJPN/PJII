using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ADONETConsole
{

    static class Extens
    {
        public static string GetStringOrNull(this SqlDataAdapter r, string columnname)
        {

            return "";// getstring blabla
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            string connstr = @"Server=dbsys.cs.vsb.cz\STUDENT;Database=kru0142;User Id=kru0142;
Password = BEC3Q9uGP3; ";
            SqlConnection dbcon = new SqlConnection(connstr);
            User[] u = new User[2];
            for (int i = 0; i < u.Length; i++)
            {
                u[i] = new User();
            }
            u[0].ID = 1;
            u[0].Firstname = "Jan";
            u[0].Lastname = "Novák";
            u[0].Age = 25;
            u[0].IsDeleted = false;

            u[1].ID = 2;
            u[1].Firstname = "Tomáš";
            u[1].Lastname = "Starý";
            u[1].Age = null;
            u[1].IsDeleted = false;


          

            
                dbcon.Open();//                 
            string command = "insert into users (FirstName,LastName,Age,IsDeleted) values (@FirstName,@LastName,@Age,@IsDeleted)";
            for (int i = 0; i < u.Length; i++)
            {
              using (SqlTransaction tr = dbcon.BeginTransaction())
                {

                SqlCommand adder = new SqlCommand(command, dbcon);
                    adder.Transaction = tr;
                adder.Parameters.Add(
                                new SqlParameter() { ParameterName = "FirstName", Value = u[0].Firstname }
                                );
                adder.Parameters.Add(
                                new SqlParameter() { ParameterName = "LastName", Value = u[0].Lastname }
                                );
                adder.Parameters.Add(
                                new SqlParameter() { ParameterName = "Age", Value = u[0].Age == null ? DBNull.Value : (object)u[0].Age }
                                );
                adder.Parameters.Add(
                                new SqlParameter() { ParameterName = "IsDeleted", Value = u[0].IsDeleted }
                                );

                adder.ExecuteNonQuery();
                    tr.Commit();
                adder.Dispose();
                }
            }
            dbcon.Close();
            dbcon = new SqlConnection(connstr);
            dbcon.Open();

            string select = "select count(*) from Users";
            SqlCommand selector = new SqlCommand(select, dbcon);
            Console.WriteLine("{0}",(int)(selector.ExecuteScalar()));
            selector.Dispose();

            dbcon.Close();


            dbcon = new SqlConnection(connstr);
            dbcon.Open();

            string select2 = "select * from Users";
            selector = new SqlCommand(select2, dbcon);
            SqlDataReader read = selector.ExecuteReader();
            while(read.Read())
            {
                User us = new User();
                us.ID = read.GetInt32(read.GetOrdinal("ID"));
                us.Firstname = read.GetString(read.GetOrdinal("FirstName"));
                us.Lastname = read.GetString(read.GetOrdinal("LastName"));
                us.Age = read.IsDBNull(read.GetOrdinal("Age"))?null: (byte?)read.GetByte(read.GetOrdinal("Age")); 
                us.IsDeleted = read.GetBoolean(read.GetOrdinal("IsDeleted"));


              //  Console.WriteLine("{0}", ));


            }
            
            selector.Dispose();

            dbcon.Close();


        }
    }
}
