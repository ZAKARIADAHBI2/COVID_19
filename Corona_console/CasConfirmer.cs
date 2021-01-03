namespace Corona_console
{
    public class CasConfirmer : test
    {
        private string NeveauRisque;
        public CasConfirmer(int id, string nom, string prenom, string CIN, double PhoneNumber, string adresse, string etatsante) : base(id, nom, prenom, CIN, PhoneNumber, adresse, etatsante)
        {
        }

        public string NeveauRisque1 { get => NeveauRisque; set => NeveauRisque = value; }
    }
}
