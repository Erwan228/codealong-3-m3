namespace Codealong3
{
    public class Brusautomat
    {
        public int Saldo { get; private set; }
        public List<Drikke> Utvalg { get; private set; }
        public Brusautomat()
        {
            Saldo = 0;
            Utvalg = new List<Drikke>();
        }
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
    }
}
