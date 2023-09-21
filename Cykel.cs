using System;
using System.Collections.Generic;
using System.Text;

namespace fordonregister_arv
{




    public class Cykel : Fordon
    {
        private string Typ;

        public Cykel(string Märke, int årsMod, string Modell, int Hästkrafter, string Typ) : base(Märke,årsMod,Modell,Hästkrafter)
        {
            this.Typ = Typ;
        }

        public override string GetMärke()
        {
            return Märke;
        }

        public override int GetårsMod()
        {
            return årsMod;
        }

        public override string GetModell()
        {
            return Modell;
        }

        public override int GetHästkrafter()
        {
            return Hästkrafter;
        }

        public string GetTyp()
        {
            return Typ;
        }
    }
}