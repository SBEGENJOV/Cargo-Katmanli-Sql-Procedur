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
    public class pCroud
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("pList", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static int uLogin(personel personel)
        {
            SqlDataAdapter adp = new SqlDataAdapter("ulogin", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@username", personel.UserName);
            adp.SelectCommand.Parameters.AddWithValue("@Password", personel.Password);

            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public static DataTable shiNoVis(personel personel)
        {
            SqlDataAdapter adp = new SqlDataAdapter("sevkNoya", tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@shipmentNo", personel.shipmentNo);

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return (dt);
        }
        public static bool Add(personel personel)
        {
            SqlCommand sqlCommand = new SqlCommand("pAdd", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@PersonelName", personel.PersonelName);
            sqlCommand.Parameters.AddWithValue("@PersonelDuty", personel.PersonelDuty);
            sqlCommand.Parameters.AddWithValue("@PersonelTitle", personel.PersonelTitle);
            sqlCommand.Parameters.AddWithValue("@PersonelTel", personel.PersonelTel);
            sqlCommand.Parameters.AddWithValue("@PersonelMail", personel.PersonelMail);
            sqlCommand.Parameters.AddWithValue("@PersonelSalary", personel.PersonelSalary);
            return tools.ConnectSet(sqlCommand);
        }
        public static bool Update(personel personel)
        {
            SqlCommand sqlCommand = new SqlCommand("pUpdate", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@PersonelNo", personel.PersonelNo);
            sqlCommand.Parameters.AddWithValue("@PersonelName", personel.PersonelName);
            sqlCommand.Parameters.AddWithValue("@PersonelDuty", personel.PersonelDuty);
            sqlCommand.Parameters.AddWithValue("@PersonelTitle", personel.PersonelTitle);
            sqlCommand.Parameters.AddWithValue("@PersonelTel", personel.PersonelTel);
            sqlCommand.Parameters.AddWithValue("@PersonelMail", personel.PersonelMail);
            sqlCommand.Parameters.AddWithValue("@PersonelSalary", personel.PersonelSalary);
            return tools.ConnectSet(sqlCommand);
        }
        public static bool Delete(personel personel)
        {
            SqlCommand sqlCommand = new SqlCommand("pDelete", tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@PersonelNo", personel.PersonelNo);
            return tools.ConnectSet(sqlCommand);
        }
    }
}
