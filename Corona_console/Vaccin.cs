using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
    public class Vaccin
    {
        private string nom;
        private float efficacite;
        private DateTime date;

        public Vaccin(string nom, float efficacite, DateTime date)
        {
            this.nom = nom;
            this.efficacite = efficacite;
            this.date = date;
        }

        public string Nom { get => nom; set => nom = value; }
        public float Efficacite { get => efficacite; set => efficacite = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
