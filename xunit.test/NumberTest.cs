using System;
using Xunit;

namespace xunit.test
{
    public class NumberTest
    {
        [Theory]
        [InlineData(3,1)]
        [InlineData(4,0)]
        [InlineData(6,-2)]
        [InlineData(7, -3)]
        [InlineData(-1,5)]
        [InlineData(-2, 6)]
        public void SuccessTest(int x, int y)
        {
            Assert.Equal(4, Add(x,y));
        }

        [Fact]
        public void FailTest()
        {
            Assert.NotEqual(10, Add(2,4));
        }


        int Add(int x, int y)
        {
            return (x >= 0 && y < 0 || y > 0) ? x + y : y + x;
        }
    }
}