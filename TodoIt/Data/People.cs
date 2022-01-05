﻿using System.Linq;

namespace TodoIt
{
    public class People
    {
        private static Person[] people = new Person[0];

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
            foreach (var person in people)
            {
                if (person.PersonId == personId)
                {
                    return person;
                }
            }

            return null;
        }

        public Person CreatePerson(string firstName, string lastName)
        {
            Person personToCreate = new Person(
                PersonSequencer.NextPersonId(),
                firstName, 
                lastName);

            people = people.Append(personToCreate).ToArray();

            return personToCreate;
        }

        public void Clear()
        {
            people = new Person[0];
        }

        public void RemovePerson(Person personToRemove)
        {
            if (FindById(personToRemove.PersonId) != null)
            {
                int peopleIndexToRemove = 0;
                Person[] newPeopleArray = new Person[0];

                for (int i = 0; i < Size(); i++)
                {
                    if (people[i] == personToRemove)
                    {
                        peopleIndexToRemove = i;
                    }
                }

                for (int i = 0; i < Size(); i++)
                {
                    if (i != peopleIndexToRemove)
                    {
                        newPeopleArray.Append(people[i]).ToArray();
                    }
                }

                people = newPeopleArray;
            }
        }
    }
}
