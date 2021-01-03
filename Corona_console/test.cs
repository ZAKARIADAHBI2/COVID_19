using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
   public class test:person
    {
        private string type;
        private Boolean result;
        public test()
        {

        }
        public test(int id,string nom, string prenom, string CIN, double PhoneNumber, string adresse, string etatsante) : base(id,nom, prenom, CIN, PhoneNumber, adresse, etatsante)
        {
        }

        public string Type { get => type; set => type = value; }
        public bool Result { get => result; set => result = value; }

        public void timeAnalyse(double AnalyseTime)
        {
            Console.WriteLine("the  Result will be ready after" + AnalyseTime + "houres");

        }
    }
}
