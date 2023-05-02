namespace Codealong3
{
    public class Lagerbeholdning
    {
        public Drikke Drikke { get; }
        private int _antall { get; set; }
        public Lagerbeholdning(Drikke drikke, int antall)
        {
            Drikke = drikke;
            _antall = antall;
        }
        public int GetAntall()
        {
            return _antall;
        }
        public void MindreAntall()
        {
            _antall--;
        }
    }
}
