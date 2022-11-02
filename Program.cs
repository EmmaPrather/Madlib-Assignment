using System;

namespace Madlib_1
{
    static class Madlib
    {
        //declare variables
        static string Creature;
        static string Luminous;
        static string Ghastly;
        static string Spectral;
        static string Countryman;
        static string Farrier;
        static string Farmer;
        static string Dreadful;
        static string Apparition;
        static string Hound;
        static string Story;

        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }

        static void Start()
        {
            //write header and instructions
            Console.WriteLine("-------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("-------");

        }

        static void GetWords()
        {
            //ask player to enter words
            Console.Write("Please enter a noun: ");
            Creature = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            Luminous = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            Ghastly = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            Spectral = Console.ReadLine();

            Console.Write("Please enter an occupation: ");
            Countryman = Console.ReadLine();

            Console.Write("Please enter an occupation: ");
            Farrier = Console.ReadLine();

            Console.Write("Please enter an occupation: ");
            Farmer = Console.ReadLine();

            Console.Write("Please enter an adjective: ");
            Dreadful = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Apparition = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Hound = Console.ReadLine();

        }

        static void WriteStory()
        {
            //write out story
            Story = "They all agreed that it was a huge " + Creature + ", " + Luminous + ", " + Ghastly + ", and " + Spectral + ". I have cross-examined these men, one of them a hard-headed " + Countryman + ", one a " + Farrier + ", and one a moorland " + Farmer + ", who all tell the same story of this " + Dreadful + " " + Apparition + ", exactly corresponding to the " + Hound + " of the legend.";
            Console.WriteLine(Story);

        }
        static void End()
        {
            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }

    }
    class Program
    {
        static void Main()
        {
            Madlib.Run();
        }
    }
}