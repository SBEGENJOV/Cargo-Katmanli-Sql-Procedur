using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class cCroud
    {
      
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("cList", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
       
        public static object Ara(customer customer)
        {
            SqlCommand sqlCommand = new SqlCommand("cSearch", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@CustomerName",customer.CustomerName);
            SqlDataAdapter dr = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            return dt;
        }
        public static bool Add(customer customer)
        {
            SqlCommand sqlCommand = new SqlCommand("cAdd", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
            sqlCommand.Parameters.AddWithValue("@CustomerAdres", customer.CustomerAdres);
            sqlCommand.Parameters.AddWithValue("@CustomerPhone", customer.CustomerPhone);
            sqlCommand.Parameters.AddWithValue("@CustomerMail", customer.CustomerMail);
            sqlCommand.Parameters.AddWithValue("@CustomerPayment", customer.CustomerPayment);
            sqlCommand.Parameters.AddWithValue("@shipmentNo", customer.shipmentNo);
            return tools.ConnectSet(sqlCommand);
        }
        public static bool Update(customer customer)
        {
            SqlCommand sqlCommand = new SqlCommand("cUpdate", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@CustomerNo", customer.CustomerNo);
            sqlCommand.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
            sqlCommand.Parameters.AddWithValue("@CustomerAdres", customer.CustomerAdres);
            sqlCommand.Parameters.AddWithValue("@CustomerPhone", customer.CustomerPhone);
            sqlCommand.Parameters.AddWithValue("@CustomerMail", customer.CustomerMail);
            sqlCommand.Parameters.AddWithValue("@CustomerPayment", customer.CustomerPayment);
            sqlCommand.Parameters.AddWithValue("@shipmentNo", customer.shipmentNo);
            return tools.ConnectSet(sqlCommand);
        }
        public static bool Delete(customer customer)
        {
            SqlCommand sqlCommand = new SqlCommand("cDelete", tools.baglanti);
            sqlCommand.Parameters.AddWithValue("@CustomerNo", customer.CustomerNo);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            return tools.ConnectSet(sqlCommand);
        }
    }
}
