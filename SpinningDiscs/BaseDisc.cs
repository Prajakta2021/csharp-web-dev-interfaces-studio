using System;
namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public string Contents { get; set; }
        public string DiscType { get; set; }

        public BaseDisc(string name, int capacity, string contents, string discType)
        {
            Name = name;
            StorageCapacity = capacity;
            Contents = contents;
            DiscType = discType;
        }
    }
}