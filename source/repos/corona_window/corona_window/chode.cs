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

    
    public partial class suive : Form
    {
        public suive()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8OVF8BK\SQLEXPRESS;Initial Catalog=prjct;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter ad = new SqlDataAdapter(cmd);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from [test]";
            cmd.Connection = con;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void suive_Load(object sender, EventArgs e)
        {

        }

        private void updatecall_Click(object sender, EventArgs e)
        {
            this.Hide();
            Result rslt = new Result();
            rslt.Show();
        }
    }
}
