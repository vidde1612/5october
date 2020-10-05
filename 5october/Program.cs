using System;

namespace _5october
{
    class Program
    {
        static void Main(string[] args)
        {
            //svar = svar man skriver in i readlines
            string svar = null;
            //rattSvar = det rätta svaret till frågan
            int rattSvar = 3;
            //nummerSvar = svaret man skriver in OM det är siffror
            int nummerSvar = 0;
            //poäng man har i slutet
            int points = 0;

            //välkomnar dig till sänka skepp och ber dig skriva in ett tal mellan 1-10
            Console.WriteLine("Hej och välkommen till sänka skepp fast budget varianten!");
            Console.WriteLine("du kommer att få skriva in ett tal mellan 1 och 10 för att sänka skeppet");
            svar = Console.ReadLine();

            //loopar tills du skriver in ett tal mellan 1-10 och ger dig information om du skriver in ett ogiltigt svar
            while (Int32.TryParse(svar, out nummerSvar) == false)
            {
                Console.WriteLine("Du skrev in ett ogiltigt svar som antingen var:");
                Console.WriteLine("högre än 10");
                Console.WriteLine("lägre än 1");
                Console.WriteLine("inte en siffra");
                svar = Console.ReadLine();
            }
            //ifs som gör att talen 0-10 ger specifika svar 
            if (nummerSvar != rattSvar && nummerSvar == 1)
            {
                Console.WriteLine("Near miss!");
                Console.ReadLine();
            }

            else if (nummerSvar != rattSvar && nummerSvar == 0)
            {
                Console.WriteLine("Står klart och tydligt att 0 inte är ett alternativ...");
                Console.ReadLine();
            }

            else if (nummerSvar != rattSvar && nummerSvar == 2)
            {
                Console.WriteLine("Near miss!");
                Console.ReadLine();
            }

            else if (nummerSvar != rattSvar && nummerSvar == 4)
            {
                Console.WriteLine("Near miss!");
                Console.ReadLine();
            }

            else if (nummerSvar != rattSvar && nummerSvar == 5)
            {
                Console.WriteLine("Near miss!");
                Console.ReadLine();
            }

            else if (nummerSvar != rattSvar && nummerSvar == 6)
            {
                Console.WriteLine("Miss!");
                Console.ReadLine();
            }

            else if (nummerSvar != rattSvar && nummerSvar == 7)
            {
                Console.WriteLine("Miss!");
                Console.ReadLine();
            }

            else if (nummerSvar != rattSvar && nummerSvar == 8)
            {
                Console.WriteLine("Miss!");
                Console.ReadLine();
            }

            else if (nummerSvar != rattSvar && nummerSvar == 9)
            {
                Console.WriteLine("Miss!");
                Console.ReadLine();
            }

            else if (nummerSvar != rattSvar && nummerSvar == 10)
            {
                Console.WriteLine("Miss!");
                Console.ReadLine();
            }
            
            //när man svarat rätt läses detta upp
            else if (nummerSvar == rattSvar)
            {
            int talDetBlev = nummerSvar * 5;
            Console.WriteLine("Hit!");
            Console.WriteLine("och fun fact " + nummerSvar + " * 5 =" + talDetBlev + "!");
            points++;
            Console.WriteLine("du har nu " + points + " poäng, grattis!");
            Console.ReadLine();
            }
        }
    }
}
