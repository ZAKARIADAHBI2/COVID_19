using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
    public class person
    {
        private string nom;
        
        private string CIN;
        private double PhoneNumber;
        private string adresse;
        private string etatsante;
        private int id;

        public person()
        {

        }
        public person(int id,string nom, string CIN, double PhoneNumber, string adresse, string etatsante)

        {
            this.nom = nom;
            this.CIN = CIN;
            this.PhoneNumber = PhoneNumber;
            this.adresse = adresse;
            this.id = id;
            this.etatsante = etatsante;
        }

        public person(int id, string nom, string prenom, string cIN, double phoneNumber, string adresse, string etatsante)
        {
            this.id = id;
            this.nom = nom;
            Prenom = prenom;
            CIN = cIN;
            PhoneNumber = phoneNumber;
            this.adresse = adresse;
            this.etatsante = etatsante;
        }

        public string Nom { get => nom; set => nom = value; }
       
        public string CIN1 { get => CIN; set => CIN = value; }
        public double PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Etatsante { get => etatsante; set => etatsante = value; }
        public int Id { get => id; set => id = value; }
        public string Prenom { get; }

        
      

       
    }
}
