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
    public class rapor
    {
     public static DataTable musSevk()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shiCus", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable musSevkNum()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shiCusNum", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable kulMax()
        {
            SqlDataAdapter adp = new SqlDataAdapter("cusMax", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable kulMin()
        {
            SqlDataAdapter adp = new SqlDataAdapter("cusin", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable kulAvg()
        {
            SqlDataAdapter adp = new SqlDataAdapter("cusAvg", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable perMax()
        {
            SqlDataAdapter adp = new SqlDataAdapter("perMax", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable perMin()
        {
            SqlDataAdapter adp = new SqlDataAdapter("perMin", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable perAvg()
        {
            SqlDataAdapter adp = new SqlDataAdapter("perAvg", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable perSum()
        {
            SqlDataAdapter adp = new SqlDataAdapter("perSum", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable shiVeh()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shiVeh", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable shiVehWho()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shiVehWho", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable shiMax()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shiMax", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable shiMin()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shiMin", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable shiAvg()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shiAvg", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable shiSum()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shiSum", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable shiMaxKm()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shiDesc", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable shiMinKm()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shiAsc", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable sevkMesafe()
        {
            SqlDataAdapter adp = new SqlDataAdapter("sevkMesafe", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable vehCap()
        {
            SqlDataAdapter adp = new SqlDataAdapter("vehCap", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable vehExp()
        {
            SqlDataAdapter adp = new SqlDataAdapter("vehExp", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable vehPer()
        {
            SqlDataAdapter adp = new SqlDataAdapter("vehPer", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable vehDri()
        {
            SqlDataAdapter adp = new SqlDataAdapter("vehDri", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
