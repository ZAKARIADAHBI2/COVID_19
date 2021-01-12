using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
    public class DossierMedical
    {
        private int id;
        private string nom;
        private string etatSente;
        private string cin;




       
        public DossierMedical(int id,string nom, string etatSente,string cin)
        {
           id = idd;
            nom = Nom;
            etatSente = EtatSente;
            this.cin = cin;
        }

        public int idd { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string EtatSente { get => etatSente; set => etatSente = value; }
        public string Cin { get => cin; set => cin = value; }
    }
}
