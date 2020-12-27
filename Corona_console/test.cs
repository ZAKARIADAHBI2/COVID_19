using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
   public class test:person
    {
        private string type;

        public test(string nom, string prenom, string CIN, double PhoneNumber, string adresse, string etatsante, int id) : base(nom, prenom, CIN, PhoneNumber, adresse, etatsante, id)
        {
        }

        public string Type { get => type; set => type = value; }

        public void timeAnalyse(double AnalyseTime)
        {
            Console.WriteLine("the  Result will be ready after" + AnalyseTime + "houres");

        }
    }
}
