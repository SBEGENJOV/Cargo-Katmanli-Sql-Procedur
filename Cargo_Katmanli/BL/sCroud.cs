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
    public class sCroud
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("sList", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable Doldur()
        {
            SqlDataAdapter adp = new SqlDataAdapter("sList", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Add( shipment shipment)
        {
            SqlCommand sqlCommand = new SqlCommand("sAdd", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@shipmentName", shipment.shipmentName);
            sqlCommand.Parameters.AddWithValue("@shipmentPickup", shipment.shipmentPickup);
            sqlCommand.Parameters.AddWithValue("@shipmentTransport", shipment.shipmentTransport);
            sqlCommand.Parameters.AddWithValue("@shipmentDistance", shipment.shipmentDistance);
            sqlCommand.Parameters.AddWithValue("@shipmentAmount", shipment.shipmentAmount);
            sqlCommand.Parameters.AddWithValue("@vehiclesNo", shipment.vehiclesNo);
            return tools.ConnectSet(sqlCommand);
        }
        public static bool Update(shipment shipment)
        {
            SqlCommand sqlCommand = new SqlCommand("sUpdate", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@shipmentNo", shipment.shipmentNo);
            sqlCommand.Parameters.AddWithValue("@shipmentName", shipment.shipmentName);
            sqlCommand.Parameters.AddWithValue("@shipmentPickup", shipment.shipmentPickup);
            sqlCommand.Parameters.AddWithValue("@shipmentTransport", shipment.shipmentTransport);
            sqlCommand.Parameters.AddWithValue("@shipmentDistance", shipment.shipmentDistance);
            sqlCommand.Parameters.AddWithValue("@shipmentAmount", shipment.shipmentAmount);
            sqlCommand.Parameters.AddWithValue("@vehiclesNo", shipment.vehiclesNo);
            return tools.ConnectSet(sqlCommand);
        }
        public static bool Delete(shipment shipment)
        {
            SqlCommand sqlCommand = new SqlCommand("sDelete", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@shipmentNo", shipment.shipmentNo);
            return tools.ConnectSet(sqlCommand);
        }
    }
}
