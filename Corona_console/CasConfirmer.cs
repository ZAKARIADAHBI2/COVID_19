using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
    public class CasConfirmer : test
    {
        private string NeveauRisque;
        public CasConfirmer(string nom, string prenom, string CIN, double PhoneNumber, string adresse, string etatsante, int id) : base(nom, prenom, CIN, PhoneNumber, adresse, etatsante, id)
        {
        }

        public void edit(CasConfirmer x)
        {
            NeveauRisque = x.NeveauRisque;
        }

    }
}
