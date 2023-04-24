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
            var drikke1 = new Drikke("Solo", 25);
            var drikke2 = new Drikke("Cola", 35);
            var drikke3 = new Drikke("Farris", 5);
            var drikke4 = new Drikke("Vann", 1025);
            var drikke5 = new Drikke("Øl", 75);
            var drikke6 = new Drikke("Monster", 30);
        }
    }
}