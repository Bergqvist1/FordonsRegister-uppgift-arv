using System;
using System.Collections.Generic;
using System.Text;

namespace fordonregister_arv
{


  public class MC : Fordon
    {
        private int cc;

        public MC(string Märke, int årsMod, string Modell, int Hästkrafter, int cc) : base(Märke,årsMod,Modell,Hästkrafter)
        {
            this.cc = cc;
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

        public int Getcc()
        {
            return cc;
        }
    }
}