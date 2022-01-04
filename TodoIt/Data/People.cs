using System;

namespace TodoIt
{
    public class People
    {
        private static Person[] people;

        public People()
        {
            this.Clear();
        }

        public int Size()
        {
            return people.Length;
        }

        public Person[] FindAll()
        {
            return people;
        }

        public Person FindById(int personId)
        {
            Person personToFind = null;

            foreach (var person in people)
            {
                if (person.PersonId == personId)
                {
                    personToFind = person;
                }
            }

            return personToFind;
        }

        public Person CreatePerson(string firstName, string lastName)
        {
            Person personToCreate = new Person(
                PersonSequencer.NextPersonId(),
                firstName, 
                lastName);

            Array.Resize(ref people, Size() + 1);

            people[Size() - 1] = personToCreate;

            return personToCreate;

        }

        public void Clear()
        {
            people = new Person[0];
        }
    }
}
