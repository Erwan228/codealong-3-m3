namespace Codealong3
{
    public class Brusautomat
    {
        public int Saldo { get; private set; }
        public List<Drikke> Utvalg = new List<Drikke>();
        public Brusautomat()
        {
            Saldo = 0;
        }
        public List<Lagerbeholdning> Lager = new List<Lagerbeholdning>();

        public void ØkSaldo(int mynt)
        {
            Saldo += mynt;
            Console.WriteLine($"Du la på {mynt}");
        }
        public void ReturnerSaldo()
        {
            Console.WriteLine("Du fikk tilbake " + Saldo);
            Saldo -= Saldo;
        }
        public void AddToLager(Drikke Drikke, int antall)
        {
            var nyttTillegg = new Lagerbeholdning(Drikke, antall);
            Lager.Add(nyttTillegg);
        }
        public void BuyStuff(Drikke drikke)
        {
            if (Saldo < drikke.Pris)
            {
                Console.WriteLine("IKKE NOK SALDO!");
                return;
            }
            else if (Lager[drikke.ID].Antall == 0)
            {
                Console.WriteLine("UTSOLGT");
            }
            else if (Saldo >= drikke.Pris && Lager[drikke.ID].Antall > 0)
            {
                Saldo -= drikke.Pris;
                Lager[drikke.ID].Antall--;
                Console.WriteLine("Du har kjøpt en " + drikke.Navn);
            }
        }
    }
}
