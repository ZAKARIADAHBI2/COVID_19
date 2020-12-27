using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
    public class person
    {
        private string nom;
        private string prenom;
        private string CIN;
        private double PhoneNumber;
        private string adresse;
        private string etatsante;
        private int id;


        public person(string nom, string prenom, string CIN, double PhoneNumber, string adresse, string etatsante, int id)

        {
            this.nom = nom;
            this.prenom = prenom;
            this.CIN = CIN;
            this.PhoneNumber = PhoneNumber;
            this.adresse = adresse;
            this.id = id;
            this.etatsante = etatsante;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string CIN1 { get => CIN; set => CIN = value; }
        public double PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Etatsante { get => etatsante; set => etatsante = value; }
        public int Id { get => id; set => id = value; }

       
        public void Getinfo(DossierMedical D1)
        {
            if (D1.idd == this.id)
            {
                this.etatsante = D1.EtatSente;

            }
            else
            {
                Console.WriteLine("no data");
            }



        }
    }
}
