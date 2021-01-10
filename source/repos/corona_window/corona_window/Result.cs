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
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8OVF8BK\SQLEXPRESS;Initial Catalog=prjct;Integrated Security=TrueData Source=DESKTOP-8OVF8BK\SQLEXPRESS;Initial Catalog=Covide;Integrated Security=True");
        //static SqlCommand cmd = new SqlCommand();
        //static SqlDataAdapter ad = new SqlDataAdapter(cmd);



        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();


           
            SqlCommand myCommand = new SqlCommand("Select * from person WHERE (IDD = '" + perid.Text + "')", con);

            SqlDataReader rdr = myCommand.ExecuteReader();

            while (rdr.Read())
            {
                string NAME = rdr["NAME"].ToString();
                string CIN = rdr["CIN"].ToString();
                string Adresse = rdr["Adresse"].ToString();
                string Etatsante = rdr["Etatsante"].ToString();

            }
            SqlCommand cmd = new SqlCommand(@"insert into CasNegative (ID, NAME,CIN,PhoneNumber,Adresse,Etatsante) VALUES
                (@ID,   @NAME,@CIN,@PhoneNumber,@Adresse,@Etatsante )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("done");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void INFECTED_Click(object sender, EventArgs e)
        {
            //insertion to casnegative
            suive suive = new suive();
            suive.Show();
        }
    }
}
