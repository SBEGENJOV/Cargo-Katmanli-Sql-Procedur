using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cargo_Katmanli
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.UserName = textBox1.Text;
            personel.Password = textBox2.Text;

            if (pCroud.uLogin(personel)==1)
            {
                MessageBox.Show("giriş başarılı");
                Form1 fgec= new Form1();
                fgec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız, Tekrar Dene");
                textBox1.Text = " ";
                textBox2.Text = " ";
            }
        }
    }
}
