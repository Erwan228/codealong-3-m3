namespace Codealong3
{
    public class Brusautomat
    {
        private int _saldo { get; set; }
        public List<Drikke> Utvalg = new List<Drikke>();
        public Brusautomat()
        {
            _saldo = 0;
        }
        public List<Lagerbeholdning> Lager = new List<Lagerbeholdning>();

        public void ØkSaldo(int mynt)
        {
            _saldo += mynt;
            Console.WriteLine($"Du la på {mynt}");
        }
        public void ReturnerSaldo()
        {
            Console.WriteLine("Du fikk tilbake " + _saldo);
            _saldo -= _saldo;
        }
        public Brusautomat AddDrink(string navn, int pris, int antall)
        {
            var drikke = new Drikke(navn, pris);
            AddToLager(drikke, antall);
            Utvalg.Add(drikke);
            return this;

        }
        public void AddToLager(Drikke drikke, int antall)
        {
            var nyttTillegg = new Lagerbeholdning(drikke, antall);
            Lager.Add(nyttTillegg);
        }
        public void ViseUtvalg()
        {
            foreach (var item in Utvalg)
            {
                Console.WriteLine($"{item.Navn} koster {item.Pris}kr!");
            }
        }
        public void ViseLager()
        {
            foreach (var produkt in Lager)
            {
                Console.WriteLine($"{produkt.Antall} {produkt.Drikke.Navn}");
            }
        }
        public void VisProdukter(bool visPris, bool visLagerbeholdning)
        {
            if (visPris) ViseUtvalg();
            if (visLagerbeholdning) ViseLager();
        }
        public void BuyStuff(string navn)
        {
            var id = 0;
            bool haveDrink = false;
            foreach (var drink in Lager)
            {
                if (drink.Drikke.Navn == navn && drink.Antall > 0)
                {
                    haveDrink = true;
                    break;

                }
                else id++;
            };

            if (haveDrink) { HaveDrink(navn, id); }
            else { Console.WriteLine("Har ikke drikken"); };
        }
        public void HaveDrink(string navn, int id)
        {
            if (_saldo < Lager[id].Drikke.Pris)
            {
                Console.WriteLine("IKKE NOK SALDO!");
                Console.WriteLine(id);
                return;
            }

            else if (_saldo >= Lager[id].Drikke.Pris)
            {
                _saldo -= Lager[id].Drikke.Pris;
                Lager[id].Antall--;
                Console.WriteLine("Du har kjøpt en " + Lager[id].Drikke.Navn);
            }
        }
    }
}
