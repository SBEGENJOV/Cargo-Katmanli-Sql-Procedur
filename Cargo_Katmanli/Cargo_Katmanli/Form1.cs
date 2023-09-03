using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using BL;
using DAL;

namespace Cargo_Katmanli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = pCroud.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cCroud.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vCroud.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sCroud.Listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox1.Location = new System.Drawing.Point(490, 10);
                this.Size = new System.Drawing.Size(870,700);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Location = new System.Drawing.Point(490, 10);
                this.Size = new System.Drawing.Size(870, 700);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox3.Location = new System.Drawing.Point(490, 10);
                this.Size = new System.Drawing.Size(870, 700);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                groupBox4.Location = new System.Drawing.Point(490, 10);
                this.Size = new System.Drawing.Size(870, 700);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            this.Size = new System.Drawing.Size(500,580);
            comboBox3.DataSource = sCroud.Listele();
            comboBox3.ValueMember ="shipmentNo";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customer customer=new customer();
            customer.CustomerName = textBox2.Text;
            customer.CustomerAdres= textBox3.Text;
            customer.CustomerPhone= textBox4.Text;
            customer.CustomerMail= textBox5.Text;
            customer.CustomerPayment =int.Parse(textBox6.Text);
            customer.shipmentNo = int.Parse(textBox7.Text);
            cCroud.Add(customer);
            dataGridView1.DataSource = cCroud.Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            personel personel=new personel();
            personel.PersonelName = textBox9.Text;
            personel.PersonelDuty = textBox10.Text;
            personel.PersonelSalary = Convert.ToInt32(textBox14.Text);
            personel.PersonelTitle= textBox11.Text;
            personel.PersonelTel= textBox12.Text;
            personel.PersonelMail= textBox13.Text;
            pCroud.Add(personel);
            dataGridView1.DataSource = pCroud.Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.PersonelNo = Convert.ToInt32(textBox8.Text);
            personel.PersonelName = textBox9.Text;
            personel.PersonelDuty = textBox10.Text;
            personel.PersonelSalary = Convert.ToInt32(textBox14.Text);
            personel.PersonelTitle = textBox11.Text;
            personel.PersonelTel = textBox12.Text;
            personel.PersonelMail = textBox13.Text;
            pCroud.Update(personel);
            dataGridView1.DataSource = pCroud.Listele();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.PersonelNo = Convert.ToInt32(textBox8.Text);
            pCroud.Delete(personel);
            dataGridView1.DataSource = pCroud.Listele();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.CustomerNo = int.Parse(textBox1.Text);
            customer.CustomerName = textBox2.Text;
            customer.CustomerAdres = textBox3.Text;
            customer.CustomerPhone = textBox4.Text;
            customer.CustomerMail = textBox5.Text;
            customer.CustomerPayment = int.Parse(textBox6.Text);
            customer.shipmentNo = int.Parse(textBox7.Text);
            cCroud.Update(customer);
            dataGridView1.DataSource = cCroud.Listele();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.CustomerNo = int.Parse(textBox1.Text);
            cCroud.Delete(customer);
            dataGridView1.DataSource = cCroud.Listele();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            shipment shipment = new shipment();
            shipment.shipmentName= textBox16.Text;
            shipment.shipmentTransport=textBox17.Text;
            shipment.shipmentPickup=textBox18.Text;
            shipment.shipmentDistance = int.Parse(textBox19.Text);
            shipment.shipmentAmount =decimal.Parse(textBox20.Text);
            shipment.vehiclesNo = int.Parse(textBox25.Text);
            sCroud.Add(shipment);
            dataGridView1.DataSource=sCroud.Listele();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            shipment shipment = new shipment();
            shipment.shipmentNo= int.Parse(textBox15.Text);
            shipment.shipmentName = textBox16.Text;
            shipment.shipmentTransport = textBox17.Text;
            shipment.shipmentPickup = textBox18.Text;
            shipment.shipmentDistance = int.Parse(textBox19.Text);
            shipment.shipmentAmount = decimal.Parse(textBox20.Text);
            shipment.vehiclesNo= int.Parse(textBox25.Text);
            sCroud.Update(shipment);
            dataGridView1.DataSource = sCroud.Listele();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            shipment shipment = new shipment();
            shipment.shipmentNo = int.Parse(textBox15.Text);
            sCroud.Delete(shipment);
            dataGridView1.DataSource = sCroud.Listele();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            vehicles vehicles = new vehicles();
            vehicles.vehicleName = textBox22.Text;
            vehicles.vehicleCapacity =Convert.ToInt32(textBox23.Text);
            vehicles.vehicleDriver = textBox24.Text;
            vehicles.vehicleExpense = decimal.Parse(textBox26.Text);
            vehicles.personelNo = int.Parse(textBox27.Text);
            vCroud.Add(vehicles);
            dataGridView1.DataSource = vCroud.Listele();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            vehicles vehicles = new vehicles();
            vehicles.vehicleNo =int.Parse(textBox21.Text);
            vehicles.vehicleName = textBox22.Text;
            vehicles.vehicleCapacity = Convert.ToInt32(textBox23.Text);
            vehicles.vehicleDriver = textBox24.Text;
            vehicles.vehicleExpense = decimal.Parse(textBox26.Text);
            vehicles.personelNo = int.Parse(textBox27.Text);
            vCroud.Update(vehicles);
            dataGridView1.DataSource = vCroud.Listele();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            vehicles vehicles = new vehicles();
            vehicles.vehicleNo = int.Parse(textBox21.Text);
            vCroud.Delete(vehicles);
            dataGridView1.DataSource = vCroud.Listele();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                dataGridView1.DataSource = cCroud.Listele();
                
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                dataGridView1.DataSource = pCroud.Listele();
                
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                dataGridView1.DataSource = sCroud.Listele();
                
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                dataGridView1.DataSource = vCroud.Listele();//tabloyu verileri aktar
               
            }
        }
        
        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable;
            dataTable=cCroud.Listele();
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = string.Format("CustomerName LIKE '%{0}%'", textBox28.Text);
            dataGridView1.DataSource = dv;
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable;
            dataTable = pCroud.Listele();
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = string.Format("PersonelName LIKE '%{0}%'", textBox28.Text);
            dataGridView1.DataSource = dv;
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable;
            dataTable = sCroud.Listele();
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = string.Format("shipmentName LIKE '%{0}%'", textBox28.Text);
            dataGridView1.DataSource = dv;
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable;// sanal tablo oluşturuyorum
            dataTable = vCroud.Listele();//sanal tabloyu dolduruyorum
            DataView dv = dataTable.DefaultView;//verileri görmek için sanal tablodan oldugu gibi çekiyorum
            dv.RowFilter = string.Format("vehicleName LIKE '%{0}%'", textBox28.Text);//verilerin sadece satırını filtrelemek istedigimi bilirtiktten sonra. arayacagım verinin string oldugunu belirtikkten sonra ne aradıgımı söylüyorum, "şu sütün adındaki" benim verecegim benzer verileri dv'ye aktar satırın tamamını
            dataGridView1.DataSource = dv;//datavievi grid e aktardım ve gösterdim
        }

        private void button17_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Araclar");

            SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS; database=Cargo;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("select * from Vehicles", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XmlElement arac = xmlDocument.CreateElement("Arac");
                XmlAttribute aracNo = xmlDocument.CreateAttribute("vehicleNo");
                aracNo.Value = reader["vehicleNo"].ToString();

                XmlAttribute aracAd = xmlDocument.CreateAttribute("vehicleName");
                aracAd.Value = reader["vehicleName"].ToString();

                XmlAttribute aracKap = xmlDocument.CreateAttribute("vehicleCapacity");
                aracKap.Value = reader["vehicleCapacity"].ToString();

                XmlAttribute aracSur = xmlDocument.CreateAttribute("vehicleDriver");
                aracSur.Value = reader["vehicleDriver"].ToString();

                XmlAttribute aracDig = xmlDocument.CreateAttribute("vehicleExpense");
                aracDig.Value = reader["vehicleExpense"].ToString();

                XmlAttribute aracSor = xmlDocument.CreateAttribute("personelNo");
                aracSor.Value = reader["personelNo"].ToString();

                arac.Attributes.Append(aracNo); 
                arac.Attributes.Append(aracAd);
                arac.Attributes.Append(aracKap);
                arac.Attributes.Append(aracSur);
                arac.Attributes.Append(aracDig);
                arac.Attributes.Append(aracSor);
                root.AppendChild(arac);
            }
            conn.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("araclar.xml");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex==0)
            {
                dataGridView1.DataSource = rapor.musSevk();
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                dataGridView1.DataSource = rapor.musSevkNum();
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                dataGridView1.DataSource = rapor.kulMax();
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                dataGridView1.DataSource = rapor.kulMin();
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                dataGridView1.DataSource = rapor.kulAvg();
            }
            else if (comboBox4.SelectedIndex == 5)
            {
                dataGridView1.DataSource = rapor.perMax();
            }
            else if (comboBox4.SelectedIndex == 6)
            {
                dataGridView1.DataSource = rapor.perMin();
            }
            else if (comboBox4.SelectedIndex == 7)
            {
                dataGridView1.DataSource = rapor.perAvg();
            }
            else if (comboBox4.SelectedIndex == 8)
            {
                dataGridView1.DataSource = rapor.perSum();
            }
            else if (comboBox4.SelectedIndex == 9)
            {
                dataGridView1.DataSource = rapor.shiVeh();
            }
            else if (comboBox4.SelectedIndex == 10)
            {
                dataGridView1.DataSource = rapor.shiVehWho();
            }
            else if (comboBox4.SelectedIndex == 11)
            {
                dataGridView1.DataSource = rapor.shiMax();
            }
            else if (comboBox4.SelectedIndex == 12)
            {
                dataGridView1.DataSource = rapor.shiMin();
            }
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex==0)
            {
            dataGridView1.DataSource= rapor.shiMaxKm();
            }
            else if (comboBox5.SelectedIndex==1)
            {
                dataGridView1.DataSource = rapor.shiMinKm();
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                dataGridView1.DataSource = rapor.sevkMesafe();
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                dataGridView1.DataSource = rapor.shiAvg();
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                dataGridView1.DataSource = rapor.shiSum();
            }
            else if (comboBox5.SelectedIndex == 5)
            {
                dataGridView1.DataSource = rapor.vehPer();
            }
            else if (comboBox5.SelectedIndex == 6)
            {
                dataGridView1.DataSource = rapor.vehCap();
            }
            else if (comboBox5.SelectedIndex == 7)
            {
                dataGridView1.DataSource = rapor.vehExp();
            }
            else if (comboBox5.SelectedIndex == 8)
            {
                dataGridView1.DataSource = rapor.vehDri();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Kullanıcılar");

            SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS; database=Cargo;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("select * from Customer", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XmlElement arac = xmlDocument.CreateElement("Musteri");
                XmlAttribute cusNo = xmlDocument.CreateAttribute("CustomerNo");
                cusNo.Value = reader["CustomerNo"].ToString();

                XmlAttribute cusName = xmlDocument.CreateAttribute("CustomerName");
                cusName.Value = reader["CustomerName"].ToString();

                XmlAttribute cusAdres = xmlDocument.CreateAttribute("CustomerAdres");
                cusAdres.Value = reader["CustomerAdres"].ToString();

                XmlAttribute cusPho = xmlDocument.CreateAttribute("CustomerPhone");
                cusPho.Value = reader["CustomerPhone"].ToString();

                XmlAttribute cusMail = xmlDocument.CreateAttribute("CustomerMail");
                cusMail.Value = reader["CustomerMail"].ToString();

                XmlAttribute cusPay = xmlDocument.CreateAttribute("CustomerPayment");
                cusPay.Value = reader["CustomerPayment"].ToString();

                XmlAttribute cusShip = xmlDocument.CreateAttribute("shipmentNo");
                cusShip.Value = reader["shipmentNo"].ToString();

                arac.Attributes.Append(cusNo);
                arac.Attributes.Append(cusName);
                arac.Attributes.Append(cusAdres);
                arac.Attributes.Append(cusPho);
                arac.Attributes.Append(cusMail);
                arac.Attributes.Append(cusPay);
                arac.Attributes.Append(cusShip);
                root.AppendChild(arac);
            }
            conn.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("musteri.xml");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Personeller");

            SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS; database=Cargo;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("select * from Personel", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XmlElement arac = xmlDocument.CreateElement("Personel");
                XmlAttribute perNo = xmlDocument.CreateAttribute("PersonelNo");
                perNo.Value = reader["PersonelNo"].ToString();

                XmlAttribute perName = xmlDocument.CreateAttribute("PersonelName");
                perName.Value = reader["PersonelName"].ToString();

                XmlAttribute perDuty = xmlDocument.CreateAttribute("PersonelDuty");
                perDuty.Value = reader["PersonelDuty"].ToString();

                XmlAttribute perTitle = xmlDocument.CreateAttribute("PersonelTitle");
                perTitle.Value = reader["PersonelTitle"].ToString();

                XmlAttribute perTel = xmlDocument.CreateAttribute("PersonelTel");
                perTel.Value = reader["PersonelTel"].ToString();

                XmlAttribute perMail = xmlDocument.CreateAttribute("PersonelMail");
                perMail.Value = reader["PersonelMail"].ToString();

                XmlAttribute perSal = xmlDocument.CreateAttribute("PersonelSalary");
                perSal.Value = reader["PersonelSalary"].ToString();

                arac.Attributes.Append(perNo);
                arac.Attributes.Append(perName);
                arac.Attributes.Append(perDuty);
                arac.Attributes.Append(perTitle);
                arac.Attributes.Append(perTel);
                arac.Attributes.Append(perMail);
                arac.Attributes.Append(perSal);
                root.AppendChild(arac);
            }
            conn.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("personeller.xml");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Sevkler");

            SqlConnection conn = new SqlConnection("Server=DESKTOP-5K7HMBT\\SQLEXPRESS; database=Cargo;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("select * from Shipment", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XmlElement arac = xmlDocument.CreateElement("Sevk");
                XmlAttribute shiNo = xmlDocument.CreateAttribute("shipmentNo");
                shiNo.Value = reader["shipmentNo"].ToString();

                XmlAttribute shiName = xmlDocument.CreateAttribute("shipmentName");
                shiName.Value = reader["shipmentName"].ToString();

                XmlAttribute shiPick = xmlDocument.CreateAttribute("shipmentPickup");
                shiPick.Value = reader["shipmentPickup"].ToString();

                XmlAttribute shiTra = xmlDocument.CreateAttribute("shipmentTransport");
                shiTra.Value = reader["shipmentTransport"].ToString();

                XmlAttribute shiDis = xmlDocument.CreateAttribute("shipmentDistance");
                shiDis.Value = reader["shipmentDistance"].ToString();

                XmlAttribute shiAmo = xmlDocument.CreateAttribute("shipmentAmount");
                shiAmo.Value = reader["shipmentAmount"].ToString();

                XmlAttribute shiVeh = xmlDocument.CreateAttribute("vehiclesNo");
                shiVeh.Value = reader["vehiclesNo"].ToString();

                arac.Attributes.Append(shiNo);
                arac.Attributes.Append(shiName);
                arac.Attributes.Append(shiPick);
                arac.Attributes.Append(shiTra);
                arac.Attributes.Append(shiDis);
                arac.Attributes.Append(shiTra);
                arac.Attributes.Append(shiVeh);
                root.AppendChild(arac);
            }
            conn.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("sevkler.xml");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.SelectedIndex!=0)
            {
                personel personel = new personel();
                personel.shipmentNo = Convert.ToInt32(comboBox3.Text);
                dataGridView1.DataSource = pCroud.shiNoVis(personel);
            }
            if (comboBox3.SelectedIndex == 0)
            {
                personel personel = new personel();
                personel.shipmentNo = Convert.ToInt32(1);
                dataGridView1.DataSource = pCroud.shiNoVis(personel);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
        }
    }
}
