using System.Diagnostics;

namespace ExternalSdk
{
    public class Person
    {
        public string Id { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public Address Address { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
}