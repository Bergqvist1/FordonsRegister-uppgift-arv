using System;
using System.Collections.Generic;
using System.Text;

namespace fordonregister_arv
{

}

    class Program
    {
        static void Main(string[] args)
        {
            int användarVal = 1;
            Lista fordon = new Lista();

            while(användarVal != 3)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Välkommen till fordonsregistret!");
                Console.WriteLine("1: Skriv in ett fordon!");
                Console.WriteLine("2: Visa fordonen i registret!");
                Console.WriteLine("3: Avsluta program!");

                användarVal = int.Parse(Console.ReadLine());

                if(användarVal == 1)
                {
                    Console.WriteLine("\n");
                    fordon.Skapa();
                }

                if(användarVal == 2)
                {
                    Console.WriteLine("\n");
                  fordon.SkrivUt();
                }

                if(användarVal == 3)
                {

                }

                else
                {
                    Console.WriteLine("Välj ett giltigt alternativ");
                }

        }

    }
}