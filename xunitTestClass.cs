using System;
using Xunit;

namespace xunitTests
{
    public class xunitTestClass
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(1,1);
        }

    }
}
