using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            DVD dvd = new DVD("Frozen II", 4700, "Movie", "DVD-PG");
            CD cd = new CD("Our trip to SFO", 650, "Pictures", "CD-RW");

            // TODO: Call each CD and DVD method to verify that they work as expected.
            dvd.SpinDisc();
            dvd.ReadData();
            cd.SpinDisc();            
            cd.ReadData();
            cd.SavedPictures();
            Console.WriteLine(dvd.Name);
            Console.WriteLine(cd.Contents);
            Console.ReadLine();
        }
    }
}