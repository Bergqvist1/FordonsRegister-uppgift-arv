using System;
using System.Collections.Generic;
using System.Text;

namespace fordonregister_arv
{


    public class FordonsLista
    {
        List<Fordon> skapa = new List<Fordon>();

        public void Skapa()
        {
            Console.WriteLine("Välj ett typ av fordon att registrera!");
            Console.WriteLine("1: Bil");
            Console.WriteLine("2: MC");
            Console.WriteLine("3: Cykel");

            int användarVal = int.Parse(Console.ReadLine());

            switch(användarVal)
            {
                case 1: 
                    Console.WriteLine("\n");
                    Console.WriteLine("Skriv in ett bil märke:");
                    string Märke = Console.ReadLine();

                    Console.WriteLine("Skriv in bilens årsmodell:");
                    int årsMod = int.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv in en modell av bil märket:");
                    string Modell = Console.ReadLine();

                    Console.WriteLine("Skriv in antalet hästkrafter:");
                    int Hästkrafter = int.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv in motorn i bilen");
                    string Motor = Console.ReadLine();

                    Bil NyBil = new Bil(Märke,årsMod,Märke,Hästkrafter,Motor);
                    skapa.Add(NyBil);
                    break;

                 case 2: 
                    Console.WriteLine("\n");
                     Console.WriteLine("Skriv in ett motorcykel märke:");
                     string Mä = Console.ReadLine();

                     Console.WriteLine("Skriv in MCns årsmodell:");
                     int årM = int.Parse(Console.ReadLine());

                      Console.WriteLine("Skriv in MCns Modell:");
                      string Mo = Console.ReadLine();

                     Console.WriteLine("Skriv in MCns Hästkrafter:");
                      int HP = int.Parse(Console.ReadLine());

                      Console.WriteLine("Skriv in MCns kubik (cc):");
                       int cc = int.Parse(Console.ReadLine());

                     MC nyMC = new MC(Mä,årM,Mo,HP,cc);
                      skapa.Add(nyMC);
                    break;

                    case 3:
                        Console.WriteLine("\n");
                        Console.WriteLine("Skriv in Cykelns märke:");
                        string Märk = Console.ReadLine();

                        Console.WriteLine("Skriv in Cykelns årsmodell:");
                        int år = Console.ReadLine();

                        Console.WriteLine("Skriv in Cykelns modell:");
                        string Mode = Console.ReadLine();

                        Console.WriteLine("Skriv in Cykelns hästkrafter :)");
                        int HorseP = int.Parse(Console.ReadLine());

                        Console.WriteLine("Skriv in Cykelns typ:");
                        string Typ = Console.ReadLine();

                        Cykel nyCykel = new Cykel(Märk,år,Mode,HorseP,Typ);
                        skapa.Add(nyCykel);
                    break;

                    default:
                    Console.WriteLine("Välj ett giltigt val!!!");
                    break;
            }

            public void SkrivUt()
            {
                foreach(var fordon in skapa)
                {
                    if(fordon is Bil bil)
                    {
                        Console.WriteLine("--------------------");
                        Console.WriteLine($"Märke: {fordon.GetMärke()}");
                        Console.WriteLine($"Årsmodell: {fordon.GetårsMod()}");
                        Console.WriteLine($"Modell: {fordon.GetModell()}");
                        Console.WriteLine($"Hästkrafter: {fordon.GetHästkrafter()}");
                        Console.WriteLine($"Motor: {bil.GetMotor()}");
                        Console.WriteLine("---------------------");
                    }

                    else if(fordon is MC mc)
                    {
                        Console.WriteLine("---------------------");
                        Console.WriteLine($"Märke: {fordon.GetMärke()}");
                        Console.WriteLine($"Årsmodell: {fordon.GetårsMod()}");
                        Console.WriteLine($"Modell: {fordon.GetModell()}");
                        Console.WriteLine($"Hästkrafter: {fordon.GetHästkrafter()}");
                        Console.WriteLine($"Kubik: {mc.Getcc()} + " cc " ");
                        Console.WriteLine("---------------------");
                    }

                    else if(fordon is Cykel cykel)
                    {
                         Console.WriteLine("---------------------");
                        Console.WriteLine($"Märke: {fordon.GetMärke()}");
                        Console.WriteLine($"Årsmodell: {fordon.GetårsMod()}");
                        Console.WriteLine($"Modell: {fordon.GetModell()}");
                        Console.WriteLine($"Hästkrafter: {fordon.GetHästkrafter()}");
                        Console.WriteLine($"Typ: {cykel.GetTyp()}");
                        Console.WriteLine("---------------------");
                    }

                    else 
                    {
                        Console.WriteLine("Känner inte igen fordonet!");
                    }
                }
            }
        }
    }
}