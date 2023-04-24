namespace Codealong3
{
    public class Drikke
    {
        public string Navn { get; private set; }
        public int Pris { get; private set; }
        public int ID { get; private set; }
        public Drikke(string navn, int pris, int iD)
        {
            Navn = navn;
            Pris = pris;
            ID = iD;
        }
    }
}
