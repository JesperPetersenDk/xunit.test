using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xunit.test
{
    class ArrayTest
    {
        [Theory]
        [InlineData(3)]
        public void NumberSuccesTest(int x)
        {
            var result = ArrayNumber[x]
            Assert.NotEqual(10, Add(x, y));
        }

        int[] ArrayNumber()
        {
            int[] result = { 4, 31, 51, -2, -22, 0 };
            return result;
        }

        string[] ArrayAll()
        {
            string[] result = { "BMW", "Ford", "Ford", "Volvo" };
            return result;
        }

    }
}
