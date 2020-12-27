using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
    public class contacts : CasConfirmer
    {


        private string NeveauRisque;

        public contacts(string nom, string prenom, string CIN, double PhoneNumber, string adresse, string etatsante, int id) : base(nom, prenom, CIN, PhoneNumber, adresse, etatsante, id)
        {
        }
       
       }
}
