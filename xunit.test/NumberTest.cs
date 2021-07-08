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
        public void AddSuccessTest(int x, int y)
        {
            Assert.Equal(4, Add(x,y));
        }

        [Theory]
        [InlineData(3, 1)]
        [InlineData(4, 0)]
        [InlineData(6, -2)]
        [InlineData(7, -3)]
        [InlineData(-1, 5)]
        [InlineData(-2, 6)]
        [InlineData(-2, -6)]
        public void AddFailTest(int x, int y)
        {
            Assert.NotEqual(10, Add(x,y));
        }


        int Add(int x, int y)
        {
            return (x >= 0 && y < 0 || y > 0) ? x + y : y + x;
        }
    }
}