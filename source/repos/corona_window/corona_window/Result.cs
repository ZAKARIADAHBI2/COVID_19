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
            color.Items.Add("Rouge");
            color.Items.Add("Verte");
            color.Items.Add("Orange");
            color.SelectedIndex = 2;

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8OVF8BK\SQLEXPRESS;Initial Catalog=prjct;Integrated Security=TrueData Source=DESKTOP-8OVF8BK\SQLEXPRESS;Initial Catalog=Covide;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter ad = new SqlDataAdapter(cmd);



        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();


            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO CasNegative(ID,NAME,CIN,PhoneNumber,Adresse,Etatsante) SELECT ID,NAME,CIN,PhoneNumber,Adresse,Etatsante from person where ID='" + perid.Text + "'";


            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("done");

            
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void INFECTED_Click(object sender, EventArgs e)
        {
            con.Open();


            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO test(TESTnbr,PERID,Result,NeveauRisqueColor,Duree) values('" + testnbr.Text+ "','" + perid.Text + "','" + rslt.Text + "','" + color.Text + "','" + duree.Text + "')";
            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("done insert to test");


           insertCc();




        }
        void insertCc()
        {

            con.Open();


            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO CasConfirmer(ID,NAME,CIN,PhoneNumber,Adresse,Etatsante,NeveauRisqueColor) SELECT ID,NAME,CIN,PhoneNumber,Adresse,Etatsante from person where ID='" + perid.Text + "','" + color.Text + "'";


            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("done");
        }
        private void rslt_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (rslt.SelectedIndex == 0)
            {
                color.Enabled = false;
                duree.Enabled = false;
            }
            else
            {
                color.Enabled = true;
                duree.Enabled = true;
            }
        }

        private void upd_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "update person set Result='" + rslt.Text + "',NeveauRisqueColor='" + color.Text + "',Duree='" + duree.Text + "' ";
            cmd.ExecuteNonQuery();

            con.Close();
            //cmd.ExecuteNonQuery();

            MessageBox.Show("update done");
        }
    }
}