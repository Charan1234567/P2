using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void works_with_Prime()
        {
            var expected = true;
            var a = 11;
            var actual = IsPrime(a);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(true, 11)]
        [InlineData(true, 3)]
        [InlineData(true, 2)]
        [InlineData(true, 1)]
        public void Prime_WorksWithManyInputs(bool exp, int x)
        {
            Assert.Equal(exp, IsPrime(x));
        }

        Boolean IsPrime(int x)
        {
            int n, i, m = 0, flag = 0;

            n = x;
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                return true;
            else
                return false;
        }
    }
}
