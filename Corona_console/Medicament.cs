using System;
using System.Collections.Generic;
using System.Text;

namespace Corona_console
{
   public class Medicament
    {
        private string type;
        private double duree;

        public string Type { get => type; set => type = value; }
        public double Duree { get => duree; set => duree = value; }

        public void edit(Medicament x)
        {
            Type = x.Type;
            duree = x.duree;

        }
    }
}
