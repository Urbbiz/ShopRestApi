using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShopRestApiUnitTests
{
    public class CalculationHelpersTests
    {
        [Fact]
        public void Multyply_Test()
        {
            var input1 = 1;
            var input2 = 2 ;

            var result = CalculationHelpers.Multiply(input1 , input2);

            result.Should().Be(2);
        }

        [Theory]
        [InlineData(2,1,2)]
        [InlineData(2,0,0)]
        public void Multyply_Theory_Test(int input1, int input2, int correctResult)
        {
            
            var result = CalculationHelpers.Multiply(input1, input2);

            result.Should().Be(correctResult);
        }
    }
}
