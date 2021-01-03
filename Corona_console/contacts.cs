using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
    public class contacts : CasConfirmer
    {


        private string NeveauRisque;

        public contacts(int id,string nom, string prenom, string CIN, double PhoneNumber, string adresse, string etatsante) : base(id,nom, prenom, CIN, PhoneNumber, adresse, etatsante)
        {
        }

        public string NeveauRisque2 { get => NeveauRisque; set => NeveauRisque = value; }
    }
}
