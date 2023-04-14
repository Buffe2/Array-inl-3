using System;
namespace Inl_uppgift_3
{
    class program
    {
        static void Main(string[] args)
        {
            string[] q = new string[4];
            string[] a = new string[4];

            q[0] = "vad heter SpaceX framtida Marsraket?";
            a[0] = "Starship";

            q[1] = "Vem var världmästaren i Formel 1 år 2021 och 2022?";
            a[1] = "Max Verstappen";

            q[2] = "Vilken ålder får man ta B-körkort?";
            a[2] = "18";

            q[3] = "Vem är statsminister i Sverige?";
            a[3] = "Ulf Kristersson";

            Console.WriteLine("Välj ett nummer mellan 1-4, det är olika frågor du får svara på.");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(q[(x - 1)]);
            string y = Console.ReadLine();

            if (y == a[(x - 1)])
            {
                Console.WriteLine("Rätt! Bra jobbat!");
            }
            else
            {
                Console.WriteLine("Fel, rätt svar var: " + a[(x - 1)]);
            }
        }
    }
}