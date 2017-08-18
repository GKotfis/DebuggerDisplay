using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExternalSdk
{
    public class PersonDebug
    {
        private readonly Person _person;

        public string Name => $"Welcome: {_person.Name}";
        public string NameLength => $"Your name has: {_person.Name.Length} chars";

        public PersonDebug(Person person)
        {
            _person = person;
        }
    }

    public class AddressDebug
    {
        private readonly Address _adrress;

        public string Address => $"{_adrress.City} - {_adrress.Street} ";

        public AddressDebug(Address address)
        {
            _adrress = address;
        }
    }
}