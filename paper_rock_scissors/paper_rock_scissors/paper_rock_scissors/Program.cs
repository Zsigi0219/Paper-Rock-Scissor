using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_rock_scissors
{
    class Program
    {

        public static int userChoice;

        public static void Eldontes(string ko, string papir, string ollo)
        {
            if (userChoice == 1)
            {
                Console.WriteLine(ko);
            }
            else if (userChoice == 2)
            {
                Console.WriteLine(papir);
            }
            else if (userChoice == 3)
            {
                Console.WriteLine(ollo);
            }
        }

        static voidd Main(string[] args)
        {
            int szamlalo = 0;
            while (true)
            {
                Console.WriteLine("Kérlek válassz az alábbiak közül: kő[1], papír[2], olló[3]");
                userChoice = int.Parse(Console.ReadLine());

                Random r = new Random();
                int computerChoice = r.Next(4);

                if (computerChoice == 1)
                {
                    Console.WriteLine("A számítógép a követ választotta");
                    Eldontes("Döntetlen", "Nyertél", "Vesztettél");
                }
                else if (computerChoice == 2)
                {
                    Console.WriteLine("A számítógép a papírt választotta");
                    Eldontes("Vesztettél", "Döntetlen", "Nyertél",);
                }
                else
                {
                    Console.WriteLine("A számítógép az ollót választotta");
                    Eldontes("Nyertél", "Vesztettél", "Döntetlen");
                }
                Console.WriteLine("Nyomj <ENTERT>");
                Console.ReadLine();
                szamlalo++;
                if (szamlalo == 5)
                {
                    Console.Clear();
                    szamlalo = 0;
                }
            }
        }

        
    }
}
