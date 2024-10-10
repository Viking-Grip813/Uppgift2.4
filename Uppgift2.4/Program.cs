using System;
namespace Uppgift2_4
{ class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Johans lön:");
            string Johanslön = Console.ReadLine();
            int tal = int.Parse(Johanslön);
            Console.WriteLine("Wiktors lön:");
            string Wiktorslön = Console.ReadLine();
            int tal2 = int.Parse(Wiktorslön);
            Console.WriteLine("Emils lön:");
            string Emilslön = Console.ReadLine();
            int tal3 = int.Parse(Emilslön);
            int medel_lön = (tal + tal2 + tal3)/3;
            Console.WriteLine("Medellönen är " + medel_lön);
        }
    }
}
