using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Corona_console
{
    class Persistance
    {


        public Persistance()
        {

        }
        //person table add , update delete
        public void Addperson(person p1, DossierMedical d1)
        {


            SqlCommand cmd = new SqlCommand();
            string connString;
            connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connString);
            if (p1.CIN1 == d1.Cin)
            {
                try
                {
                    sqlConnection.Open();

                    cmd.Connection = sqlConnection;
                    cmd.CommandText = "insert into person (ID,NAME,CIN,PhoneNumber,Adresse,Etatsante) values('" + p1.Id + "','" + p1.Nom + "','" + p1.CIN1 + "','" + p1.PhoneNumber1 + "','" + p1.Adresse + "','" + d1.EtatSente + "') ";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());
                }

            }
            //person doesn't have D.M
            else
            {
                

                try
                {
                    sqlConnection.Open();

                    cmd.Connection = sqlConnection;
                    cmd.CommandText = "insert into person (ID,NAME,CIN,PhoneNumber,Adresse,Etatsante) values('" + p1.Id + "','" + p1.Nom + "','" + p1.CIN1 + "','" + p1.PhoneNumber1 + "','" + p1.Adresse + "','" + null + "') ";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public void editperson(person p1)
        {


            SqlCommand cmd = new SqlCommand();
            string connString;
            connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                
                cmd.Connection = sqlConnection;
                cmd.CommandText = "update person set NAME='" + p1.Nom + "',CIN='" + p1.CIN1 + "',PhoneNumber='" + p1.PhoneNumber1 + "',Adresse='" + p1.PhoneNumber1 + "',Etatsante='" + p1.Etatsante + "')";
                cmd.ExecuteNonQuery();


                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
        public void deletperson(person p1)
        {



            string connString;
            connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
            // create Sqlconnection object
            SqlConnection sqlConnection = new SqlConnection(connString);

            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("Delete person  Where ID=@ID)", sqlConnection);

                cmd.Connection = sqlConnection;
                cmd.CommandText = "delete from  person where ID='" + p1.Id + "' ";
                cmd.ExecuteNonQuery();


                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
        //dossier table add , update 

        public void AddDossier(DossierMedical d1)
        {


            SqlCommand cmd = new SqlCommand();
            string connString;
            connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connString);

            sqlConnection.Close();
            try
            {
                sqlConnection.Open();

                cmd.Connection = sqlConnection;
                cmd.CommandText = "insert into Dossier (IDD,NAME,Etatsante) values('" + d1.idd + "','" + d1.Nom + "','" + d1.EtatSente + "') ";
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        public void editDossie(DossierMedical d1)
        {


            SqlCommand cmd = new SqlCommand();
            string connString;
            connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();

                cmd.Connection = sqlConnection;
                cmd.CommandText = "update Dossier set NAME='" + d1.Nom + "',Etatsante='" + d1.EtatSente + "')";
                cmd.ExecuteNonQuery();


                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
        //add casConfirmer
        public void addcas(CasConfirmer cas1)
        {
            test t1 = new test();
            //true means positive
            if (t1.Result == true)
            {
                SqlCommand cmd = new SqlCommand();
                string connString;
                connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connString);

                try
                {
                    sqlConnection.Open();

                    cmd.Connection = sqlConnection;
                    cmd.CommandText = "insert into CasConfirmer (ID,NAME,CIN,PhoneNumber,Adresse,Etatsante,NeveauRisqueColor) values('" + cas1.Id + "','" + cas1.Nom + "','" + cas1.CIN1 + "','" + cas1.PhoneNumber1 + "','" + cas1.Adresse + "','" + cas1.Etatsante + "','" + cas1.NeveauRisque1 + "') ";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());
                }


            }//false means nigative

        }
        //upadate casConfirmer
        public void updateCas(CasConfirmer Cas1)
        {


            SqlCommand cmd = new SqlCommand();
            string connString;
            connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();

                cmd.Connection = sqlConnection;
                cmd.CommandText = "update CasConfirmer set NAME='" + Cas1.Nom + "',CIN='" + Cas1.CIN1 + "',PhoneNumber='" + Cas1.PhoneNumber1 + "',Adresse='" + Cas1.PhoneNumber1 + "',Etatsante='" + Cas1.Etatsante + "',NeveauRisqueColor='" + Cas1.NeveauRisque1 + "')";
                cmd.ExecuteNonQuery();


                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }
        }
        //delete casConfirmer
        public void deleteCas(CasConfirmer Cas1)
        {
            string connString;
            connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
            // create Sqlconnection object
            SqlConnection sqlConnection = new SqlConnection(connString);

            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("Delete CasConfirmer  Where ID=@ID)", sqlConnection);

                cmd.Connection = sqlConnection;
                cmd.CommandText = "delete from  CasConfirmer where ID='" + Cas1.Id + "' ";
                cmd.ExecuteNonQuery();


                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
        //ADD contacts
        //add casnegative
        public void addcasnegative(CasNegative casn)
        {
            test t1 = new test();
            //false means negative
            if (t1.Result == false)
            {
                
                    SqlCommand cmd = new SqlCommand();
                    string connString;
                    connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connString);

                    try
                    {
                        sqlConnection.Open();

                        cmd.Connection = sqlConnection;
                        cmd.CommandText = "insert into CasNegative (ID,NAME,CIN,PhoneNumber,Adresse,Etatsante,NeveauRisqueColor) values('" + casn.Id + "','" + casn.Nom + "','" + casn.CIN1 + "','" + casn.PhoneNumber1 + "','" + casn.Adresse + "','" + casn.Etatsante + "') ";
                        cmd.ExecuteNonQuery();

                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.ToString());
                    }
                

            }
        }
        //upadate casnegative
        public void CasNegative(CasNegative casn)
        {
            SqlCommand cmd = new SqlCommand();
            string connString;
            connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();

                cmd.Connection = sqlConnection;
                cmd.CommandText = "update CasNegative set NAME='" + casn.Nom + "',CIN='" + casn.CIN1 + "',PhoneNumber='" + casn.PhoneNumber1 + "',Adresse='" + casn.PhoneNumber1 + "',Etatsante='" + casn.Etatsante + "')";
                cmd.ExecuteNonQuery();


                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }
        }
        //delete Casnegative
        public void deleteCas(CasNegative casn)
        {
            string connString;
            connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
            // create Sqlconnection object
            SqlConnection sqlConnection = new SqlConnection(connString);

            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("Delete CasNegative  Where ID=@ID)", sqlConnection);

                cmd.Connection = sqlConnection;
                cmd.CommandText = "delete from  CasNegative where ID='" + casn.Id + "' ";
                cmd.ExecuteNonQuery();


                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
        void suive(test t1)
        {
            string connString;
            connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
            // create Sqlconnection object
            SqlConnection sqlConnection = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();

            try
            {
                sqlConnection.Open();


                cmd.Connection = sqlConnection;
                cmd.CommandText = "select PERID,Result,NeveauRisqueColor,Duree from test where PERID ='" + t1.Id + "'";
                cmd.ExecuteNonQuery();


                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
            void updateCass(test t1)
            {
                SqlCommand cmd = new SqlCommand();
                string connString;
                connString = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connString);
                try
                {
                    sqlConnection.Open();

                    cmd.Connection = sqlConnection;
                    cmd.CommandText = "update test set Result='" + t1.Result + "',NeveauRisqueColor='" + t1.Color + "',Duree='" + t1.Duree1 + "')";
                    cmd.ExecuteNonQuery();


                    sqlConnection.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());

                }
            }

        }
    } 




