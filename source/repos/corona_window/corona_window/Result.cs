using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace corona_window
{
    public partial class Result : Form
    {
       
        public Result()
        {
            InitializeComponent();
            rslt.Items.Add("Negative");
            rslt.Items.Add("positive");
            rslt.SelectedIndex = 0;

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8OVF8BK\SQLEXPRESS;Initial Catalog=prjct;Integrated Security=TrueData Source=DESKTOP-8OVF8BK\SQLEXPRESS;Initial Catalog=Covide;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter ad = new SqlDataAdapter(cmd);



        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();


            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO CasNegative(NAME,CIN,PhoneNumber,Adresse,Etatsante) SELECT NAME,CIN,PhoneNumber,Adresse,Etatsante from person where ID='"+perid.Text+"'";


            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("done");

            //insertion to casnegative
            suive suive = new suive();
            suive.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void INFECTED_Click(object sender, EventArgs e)
        {
            con.Open();


            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO CasNegative(NAME,CIN,PhoneNumber,Adresse,Etatsante,NeveauRisqueColor) SELECT NAME,CIN,PhoneNumber,Adresse,Etatsante from person where ID='" + perid.Text + "'";
            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("done");

            //insertion to casnegative
            suive suive = new suive();
            suive.Show();


         }

        private void rslt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (rslt.SelectedIndex == 0)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
            }
        }
    }
}
