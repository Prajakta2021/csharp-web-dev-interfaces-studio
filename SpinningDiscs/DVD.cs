using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface. 
        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }

        public void ReadData()
        {
            Console.WriteLine("Read and write DVD.");
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class
        // and which ones need to be declared separately.

        public DVD(string name, int capacity, string contents, string discType) : base(name, capacity, contents, discType)
        {
        }
    }
}