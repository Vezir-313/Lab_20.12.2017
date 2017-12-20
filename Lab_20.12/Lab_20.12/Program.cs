using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20._12
{
    class Program
    {

         void areYouReady(string name, string surname)
        {



            Console.Write("{1} {0} imtahana hazirsan ? yes/no :", name, surname);
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("Bawladi");
            }

            else if (answer == "no")
            {
                Console.WriteLine("hazirraw");
            }

            else
            {
                Console.WriteLine("dungunn daxil edin!!!");
                areYouReady(name,surname);

            }
           
        }
        static void Main(string[] args)
        {
            var prg = new Program();
            string Name;
            string surname;
            Console.Write("Adin Nedi :");

            Name = Console.ReadLine();

            Console.Write("Soyadin Nedi :");

            surname = Console.ReadLine();

            Console.WriteLine("\n");

            
           

            prg.areYouReady(Name,surname);

           

            
        }
    }
}
