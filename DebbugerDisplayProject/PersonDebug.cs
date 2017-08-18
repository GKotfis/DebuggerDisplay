using ExternalSdk;

namespace DebbugerDisplayProject
{
    public class PersonDebug
    {
        private readonly Person _person;

        public string Id { get { return _person.Id; } }

        public PersonDebug(Person person)
        {
            _person = person;
        }
    }
}
