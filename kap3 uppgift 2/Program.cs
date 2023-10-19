using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara med J eller N");
            string gymnasie = Console.ReadLine().ToLower();

            Console.WriteLine("Hur gammal är du? Svara i heltal");
            int ålder = int.Parse(Console.ReadLine());

            if (gymnasie == "j" && ålder < 22)
            {
                Console.WriteLine("Vi vill anställa dig.");
            }
            else
            {
                Console.WriteLine("förlåt, vi letar efter en annan personal just nu");
            }

            Console.ReadKey();
        }
    }
}