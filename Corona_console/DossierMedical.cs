using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
    public class DossierMedical
    {
        private int id;
        private string etatSente;




       
        public DossierMedical(int id, string etatSente)
        {
           id = idd;
            etatSente = EtatSente;
        }

        public int idd { get => id; set => id = value; }
        public string EtatSente { get => etatSente; set => etatSente = value; }

       

        public void ajoute(int id , string etatSente)
        {
            this.id = id;
            this.etatSente = etatSente;

        }
        public void modifier(int id,string etatSente)
        {
            if (id == this.id)
            {
                Console.WriteLine("enter the new data");
                etatSente = Console.ReadLine();


                this.etatSente = etatSente;
            }
            else
                Console.WriteLine("unsaved id");
        }


    }
}
