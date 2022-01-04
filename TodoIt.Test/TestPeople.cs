using Xunit;

namespace TodoIt.Test
{
    public class TestPeople
    {
        private readonly People people;

        public TestPeople()
        {
            PersonSequencer.Reset();
            people = new People();
        }

        private void AddPersonsToPeople(int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                people.CreatePerson($"FirstName{i}", $"LastName{i}");
            }
        }

        [Fact]
        public void TestPeopleInitializedToZeroLength()
        {
            Assert.Empty(people.FindAll());
        }

        [Theory]
        [InlineData(10)]
        public void TestPeopleSize(int iterations)
        {
            AddPersonsToPeople(iterations);

            Assert.Equal(iterations, people.Size());
        }

        [Theory]
        [InlineData(2)]
        public void TestPeopleFindById(int iterations)
        {
            AddPersonsToPeople(iterations);

            for (int i = 0; i < iterations; i++)
            {
                Assert.Equal($"FirstName{i}", people.FindById(i).FirstName);
                Assert.Equal($"LastName{i}", people.FindById(i).LastName);
            }
        }

        [Theory]
        [InlineData(2)]
        public void TestPeopleCreatePerson(int iterations)
        {
            AddPersonsToPeople(iterations);

            for (int i = 0; i < iterations; i++)
            {
                Assert.Equal($"FirstName{i}", people.FindAll()[i].FirstName);
                Assert.Equal($"LastName{i}", people.FindAll()[i].LastName);
            }
        }

    }
}
