namespace Codealong3
{
    public class Drikke
    {
        private string _navn { get; set; }
        private int _pris { get; set; }
        public Drikke(string navn, int pris)
        {
            _navn = navn;
            _pris = pris;
        }
        public void Show()
        {
            Console.WriteLine($"{_navn} koster {_pris}kr!");
        }
        public string GetNavn()
        {
            return _navn.ToString();
        }
        public int GetPris()
        {
            return _pris;
        }
    }
}
