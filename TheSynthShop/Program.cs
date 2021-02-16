using System;
using System.IO;

namespace TheSynthShop
{
    class Program
    {



        static void Main()
        {
            // Shopping app. Uaser purches Modualar synth moduals
            Console.WriteLine("The Synth Shop!");

            //Master loop
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

                Console.WriteLine("What kind? ");
                string OneSynth = Console.ReadLine();


                File.AppendAllText(@"C:\Users\TSG\source\repos\SynthShop\TheSynthShop\data.txt", (OneSynth) + Environment.NewLine);
            }

        }
    }
}
