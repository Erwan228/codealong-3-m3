namespace Codealong3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var brusautomat = new Brusautomat();
            brusautomat.ØkSaldo(20);
            brusautomat.ØkSaldo(5);
            brusautomat.ReturnerSaldo();
            brusautomat.AddDrink("Solo", 25, 6)
            .AddDrink("Cola", 35, 6)
            .AddDrink("Farris", 5, 23)
            .AddDrink("Vann", 1, 1)
            .AddDrink("Øl", 75, 3)
            .AddDrink("Monster", 30, 223323);
            //var Solo = new Drikke("Solo", 25, 0);
            //var Cola = new Drikke("Cola", 35, 1);
            //var Farris = new Drikke("Farris", 5, 2);
            //var Vann = new Drikke("Vann", 1, 3);
            //var Øl = new Drikke("Øl", 75, 4);
            //var Monster = new Drikke("Monster", 30, 5);
            //Brusautomat.Utvalg.Add(Solo);
            //Brusautomat.Utvalg.Add(Farris);
            //Brusautomat.Utvalg.Add(Vann);
            //Brusautomat.Utvalg.Add(Øl);
            //Brusautomat.Utvalg.Add(Monster);
            brusautomat.VisProdukter(true, false);
            //Brusautomat.AddToLager(Solo, 6);
            //Brusautomat.AddToLager(Farris, 23);
            //Brusautomat.AddToLager(Cola, 2);
            //Brusautomat.AddToLager(Vann, 1);
            //Brusautomat.AddToLager(Øl, 3);
            //Brusautomat.AddToLager(Monster, 223323);
            brusautomat.VisProdukter(false, true);
            brusautomat.ØkSaldo(5);
            brusautomat.BuyStuff("Vann");
            brusautomat.BuyStuff("Vann");
            brusautomat.ReturnerSaldo();
        }
    }
}