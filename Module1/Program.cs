using System;
using System.Collections.Generic;
using Module1;

namespace Animals
{
    class Program
    {
        private static FileOutput _outFile = new FileOutput("animals.txt");

        static void Main(string[] args)
        {
            List<Talkable> zoo = new List<Talkable>();

            // Lines to Replace Begin Here
            NewAnimal creator = new NewAnimal(zoo);
            creator.AddAnimal();
            // End Lines to Replace

            foreach (var thing in zoo)
            {
                PrintOut(thing);
            }

            _outFile.FileClose();

            // Reading from the file
            FileInput inData = new FileInput("animals.txt");
            string line;
            while ((line = inData.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            inData.FileClose();
        }

        public static void PrintOut(Talkable p)
        {
            Console.WriteLine($"{p.Name} says={p.Talk()}");
            _outFile.FileWrite($"{p.Name} | {p.Talk()}");
        }
    }
}

