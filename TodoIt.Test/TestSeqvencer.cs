using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoIt;

namespace TodoIt.Test
{

    public class TestSeqvencer
    {
        [Fact]
        public void TestPersonId()
        {
            int result = 0;
            int id = Data.PersonSeqvencer.NextPersonId();
            Assert.Equal(id, result);

            id = Data.PersonSeqvencer.NextPersonId();
            result = 1;
            Assert.Equal(id, result);
        }

        [Fact]
        public void TestReset()
        {
            int result = 0;
            int id;

            Data.PersonSeqvencer.Reset();
            id = Data.PersonSeqvencer.NextPersonId();

            Assert.Equal(id, result);
        }
    }
}
