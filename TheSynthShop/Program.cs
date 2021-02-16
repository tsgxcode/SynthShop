using System;

namespace TheSynthShop
{
    class Program
    {



        static void Main()
        {
            Console.WriteLine("The Synth Shop!");

            do
            {
                Console.WriteLine("New Synth Modual? ");

                addNewModual();
                Console.WriteLine("Would you like to see the current list? ");
                if (Console.ReadLine().ToUpper() == "YES") 
                {
                    addNewModual();
                }
                Console.WriteLine("Buy Another? ");

            } while (Console.ReadLine().ToUpper() == "YES");


             static void addNewModual()
            {

                Console.WriteLine("Buy a synth? ");
                string OneSynth = Console.ReadLine();
            }

        }
    }
}
