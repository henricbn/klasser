using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            /* övning 1
            Bil car = new Bil();


            Console.WriteLine("Välj ett bil märke:");
            car.märke = Console.ReadLine();
            Console.WriteLine("Välj en modell:");
            car.modell = Console.ReadLine();
            Console.WriteLine("Vilken färg ska bilen ha?");
            car.färg = Console.ReadLine();
            Console.WriteLine("Hur många hästkrafter ska motorn ha?");
            car.hk = Console.ReadLine();
            Console.WriteLine("Hur många säten ska bilen ha?");
            car.platser = Console.ReadLine();

            Console.WriteLine("du har köpt en " + car.märke + " " + car.modell + " med färgen " + car.färg + " motorn har " + car.hk + " hästkrafter " + " och " + car.platser + " platser");
            */
            /* övning 2

            Namn namnen = new Namn();
            Console.WriteLine("Skriv ditt förnamn: ");
            namnen.förnamn = Console.ReadLine();
            Console.WriteLine("Skriv ditt efternamn: ");
            namnen.efternamn = Console.ReadLine();
            Console.WriteLine("ditt namn är " + namnen.föroeft);
        */
            Namn namnen = new Namn();
            Console.WriteLine("Skriv ditt förnamn: ");
            namnen.förnamn = Console.ReadLine();
            Console.WriteLine("Skriv ditt efternamn: ");
            namnen.efternamn = Console.ReadLine();
            Console.WriteLine("Skriv in ditt födelse datum: ");
            namnen.date = Console.ReadLine();
            Console.WriteLine("ditt namn är " + namnen.föroeft); 
        }
    }
}
