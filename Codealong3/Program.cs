namespace Codealong3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Brusautomat = new Brusautomat();
            Brusautomat.ØkSaldo(20);
            Brusautomat.ØkSaldo(5);
            Brusautomat.ReturnerSaldo();
            var Solo = new Drikke("Solo", 25, 0);
            var Cola = new Drikke("Cola", 35, 1);
            var Farris = new Drikke("Farris", 5, 2);
            var Vann = new Drikke("Vann", 1, 3);
            var Øl = new Drikke("Øl", 75, 4);
            var Monster = new Drikke("Monster", 30, 5);
            Brusautomat.Utvalg.Add(Solo);
            Brusautomat.Utvalg.Add(Farris);
            Brusautomat.Utvalg.Add(Vann);
            Brusautomat.Utvalg.Add(Øl);
            Brusautomat.Utvalg.Add(Monster);
            foreach (Drikke drikke in Brusautomat.Utvalg)
            {
                Console.WriteLine($"{drikke.Navn} koster {drikke.Pris}kr!");
            }
            Brusautomat.AddToLager(Solo, 6);
            Brusautomat.AddToLager(Farris, 23);
            Brusautomat.AddToLager(Cola, 2);
            Brusautomat.AddToLager(Vann, 1);
            Brusautomat.AddToLager(Øl, 3);
            Brusautomat.AddToLager(Monster, 223323);
            foreach (Lagerbeholdning Produkt in Brusautomat.Lager) { Console.WriteLine($"{Produkt.Antall} {Produkt.Drikke.Navn}"); }
            Brusautomat.ØkSaldo(5);
            Brusautomat.BuyStuff(Vann);
            Brusautomat.BuyStuff(Vann);
            Brusautomat.ReturnerSaldo();
        }
    }
}