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
    public class vCroud
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("vList", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Add(vehicles vehicles)
        {
            SqlCommand sqlCommand = new SqlCommand("vAdd", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@vehicleName", vehicles.vehicleName);
            sqlCommand.Parameters.AddWithValue("@vehicleCapacity", vehicles.vehicleCapacity);
            sqlCommand.Parameters.AddWithValue("@vehicleDriver", vehicles.vehicleDriver);
            sqlCommand.Parameters.AddWithValue("@vehicleExpense", vehicles.vehicleExpense);
            sqlCommand.Parameters.AddWithValue("@personelNo", vehicles.personelNo);
            return tools.ConnectSet(sqlCommand);
        }
        public static bool Update(vehicles vehicles)
        {
            SqlCommand sqlCommand = new SqlCommand("vUpdate", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@vehicleNo", vehicles.vehicleNo);
            sqlCommand.Parameters.AddWithValue("@vehicleName", vehicles.vehicleName);
            sqlCommand.Parameters.AddWithValue("@vehicleCapacity", vehicles.vehicleCapacity);
            sqlCommand.Parameters.AddWithValue("@vehicleDriver", vehicles.vehicleDriver);
            sqlCommand.Parameters.AddWithValue("@vehicleExpense", vehicles.vehicleExpense);
            sqlCommand.Parameters.AddWithValue("@personelNo", vehicles.personelNo);
            return tools.ConnectSet(sqlCommand);
        }
        public static bool Delete(vehicles vehicles)
        {
            SqlCommand sqlCommand = new SqlCommand("vDelete", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@vehicleNo", vehicles.vehicleNo);
            return tools.ConnectSet(sqlCommand);
        }
    }
}
