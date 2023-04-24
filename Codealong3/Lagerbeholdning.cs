namespace Codealong3
{
    public class Lagerbeholdning
    {
        public Drikke Drikke { get; }
        public int Antall { get; set; }
        public Lagerbeholdning(Drikke drikke, int antall)
        {
            Drikke = drikke;
            Antall = antall;
        }
    }
}
