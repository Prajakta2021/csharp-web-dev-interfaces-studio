using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface
        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }
        public void ReadData()
        {
            Console.WriteLine("Read and write CD.");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which one need to be declared separately.
        public CD(string name, int capacity, string contents, string discType) : base(name, capacity, contents, discType)
        {
        }
        public void SavedPictures()
        {
            Console.WriteLine("These are some beautiful pictures!");
        }
    }
}