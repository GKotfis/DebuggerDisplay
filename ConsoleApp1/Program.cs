using System;
using ExternalSdk;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           Person person = new Person()
            {
                Id = "1",
                Name = "Jan Kowalski",
                Address = new Address { City = "Gdynia", Street = "10 lutego" }
            };

            Console.WriteLine(person);
        }
    }
}