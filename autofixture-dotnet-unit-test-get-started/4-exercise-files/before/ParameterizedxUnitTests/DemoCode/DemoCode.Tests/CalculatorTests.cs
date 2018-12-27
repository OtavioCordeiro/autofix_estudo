using System;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Xunit;
using Xunit;
using Xunit.Extensions;


namespace DemoCode.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTwoPositiveNumbers()
        {
            var sut = new Calculator();  

            sut.Add(1);
            sut.Add(2);

            Assert.Equal(3, sut.Value);
        }


        [Fact]
        public void AddZeroAndPositiveNumber()
        {
            var sut = new Calculator();

            sut.Add(0);
            sut.Add(2);

            Assert.Equal(2, sut.Value);
        }


        [Fact]
        public void AddNegativeAndPositiveNumber()
        {
            var sut = new Calculator();

            sut.Add(-5);
            sut.Add(1);

            Assert.Equal(-4, sut.Value);
        }


    
    }
}
