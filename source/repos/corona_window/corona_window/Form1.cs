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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8OVF8BK\SQLEXPRESS;Initial Catalog=prjct;Integrated Security=TrueData Source=DESKTOP-8OVF8BK\SQLEXPRESS;Initial Catalog=Covide;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter ad = new SqlDataAdapter(cmd);



        

        private void button2_Click(object sender, EventArgs e)
        {
            
            con.Open();
          

            cmd.Connection = con;
            if (oui.Checked)
            {
                
               // cmd.CommandText = "Select Etatsante from [Dossier] WHERE (IDD = '" + IDperson.Text + "')";
                //cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into [person] (ID,NAME,CIN,PhoneNumber,Adress,Etatsante) values('" + IDperson.Text + "','" + Nomper.Text + "','" + CINper.Text + "','" + tleper.Text + "','" + adresseper.Text + "',Select Etatsante from[Dossier] WHERE(IDD = '" + IDperson.Text + "'))";
                cmd.ExecuteNonQuery();
            }
            else if (non.Checked)
            {
                cmd.CommandText = "insert into [person] (ID,NAME,CIN,PhoneNumber,Adresse,Etatsante) values('" + IDperson.Text + "','" + Nomper.Text + "','" + CINper.Text + "','" + tleper.Text + "','" + adresseper.Text + "','" + "Null" + "') ";
                cmd.ExecuteNonQuery();
            }
           


            con.Close();
            MessageBox.Show("done");
            this.Hide();

            Result Result = new Result();
            Result.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Result Result = new Result();
            Result.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            suive suive = new suive();
            suive.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "update person set NAME='" +Nomper.Text  + "',CIN='" + CINper.Text + "',PhoneNumber='" + tleper.Text + "',Adresse='" + adresseper.Text + "' where ID='" +IDperson.Text + "' ";
            cmd.ExecuteNonQuery();

            con.Close();
            //cmd.ExecuteNonQuery();

            MessageBox.Show("update done");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete person Where ID=@ID)", con);

            cmd.Connection = con;
            cmd.CommandText = "delete from  person where ID='" + IDperson.Text + "' ";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("deleted");
        }
    }
}
