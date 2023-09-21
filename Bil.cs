using System;
using System.Collections.Generic;
using System.Text;

namespace fordonregister_arv
{


    public class Bil : Fordon
    {
        private string Motor;
        public Bil(string Märke, int årsMod, string Modell, int Hästkrafter, string Motor): base(Märke,årsMod,Modell,Hästkrafter)
        {
            this.Motor = Motor;
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

        public string GetMotor()
        {
            return Motor;
        }
    }
}