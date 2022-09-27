using System.ComponentModel;

namespace DaprNBlocks.Samples.Pet.Api
{
    public class Pet
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Category? Category { get; set; }
        public int Age { get; set; }
    }
}