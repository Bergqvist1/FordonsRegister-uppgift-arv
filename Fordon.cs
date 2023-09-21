using System;
using System.Collections.Generic;
using System.Text;

namespace fordonregister_arv
{


    public class Fordon
    {
        protected string Märke;
        protected int årsMod;
        protected string Modell;
        protected int Hästkrafter;

        public Fordon(string Märke, int årsMod, string Modell, int Hästkrafter)
        {
            this.Märke = Märke;
            this.årsMod = årsMod;
            this.Modell = Modell;
            this.Hästkrafter = Hästkrafter;
        }

        public virtual string GetMärke()
        {
            return "";
        }

        public virtual int GetårsMod()
        {
            return 0; 
        }

        public virtual string GetModell()
        {
            return "";
        }

        public virtual int GetHästkrafter()
        {
            return 0;
        }
    }
}