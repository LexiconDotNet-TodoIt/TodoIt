
namespace TodoIt.Test
{

    using Xunit;

    public class TestPersonSequencer
    {
        public TestPersonSequencer()
        {
            PersonSequencer.Reset();
        }

        [Fact]
        public void TestPersonId()
        {
            int result = 0;
            int id = PersonSequencer.NextPersonId();
            Assert.Equal(id, result);

            id = PersonSequencer.NextPersonId();
            result = 1;
            Assert.Equal(id, result);
        }

        [Fact]
        public void TestReset()
        {
            int result = 0;
            int id;

            PersonSequencer.Reset();
            id = PersonSequencer.NextPersonId();

            Assert.Equal(id, result);
        }
    }
}
