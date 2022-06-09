using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALCustomer
    {
        public static List<EntityCustomers> CustomersList()
        {
            List<EntityCustomers> valuess = new List<EntityCustomers>();
            SqlCommand comm = new SqlCommand("select * from Tbl_Customers", Connectionn.conn);
            if (comm.Connection.State != ConnectionState.Open)
            {
                comm.Connection.Open();
            }
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                EntityCustomers ec = new EntityCustomers();
                ec.Id = int.Parse(dr["ID"].ToString());
                ec.Name = dr["NAME"].ToString();
                ec.LastName = dr["LASTNAME"].ToString();
                ec.City = dr["CITY"].ToString();
                ec.Task = dr["TASK"].ToString();
                ec.Paying = short.Parse(dr["PAYING"].ToString());
                valuess.Add(ec);
            }
            dr.Close();
            return valuess;
        }

        public static int CustomerAdd(EntityCustomers C)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Customers(NAME,LASTNAME,CITY,TASK,PAYING) VALUES(@name,@lastname,@city,@task,@paying)",Connectionn.conn);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@name", C.Name);
            command.Parameters.AddWithValue("@lastname", C.LastName);
            command.Parameters.AddWithValue("@city", C.City);
            command.Parameters.AddWithValue("@task", C.Task);
            command.Parameters.AddWithValue("@paying", C.Paying);
            return command.ExecuteNonQuery();

        }

        public static bool CustomerDelet(int D)
        {
            SqlCommand commandd = new SqlCommand("Delete from Tbl_Customers WHERE ID = @ID", Connectionn.conn);
            if (commandd.Connection.State != ConnectionState.Open)
            {
                commandd.Connection.Open();
            }
            commandd.Parameters.AddWithValue("@ID", D);
            return commandd.ExecuteNonQuery() > 0;
        }

        public static int CustomerUpdate(EntityCustomers U)
        {
            SqlCommand commanddd = new SqlCommand("UPDATE Tbl_Customers set NAME = @name, LASTNAME = @lastname, CITY = @city, TASK = @task, PAYING = @paying  WHERE ID = @ID", Connectionn.conn);
            if (commanddd.Connection.State != ConnectionState.Open)
            {
                commanddd.Connection.Open();
            }

            commanddd.Parameters.AddWithValue("@ID", U.Id);
            commanddd.Parameters.AddWithValue("@name",U.Name);
            commanddd.Parameters.AddWithValue("@lastname", U.LastName);
            commanddd.Parameters.AddWithValue("@city", U.City);
            commanddd.Parameters.AddWithValue("@task", U.Task);
            commanddd.Parameters.AddWithValue("@paying", U.Paying);
            return commanddd.ExecuteNonQuery();
        }
    }
}
