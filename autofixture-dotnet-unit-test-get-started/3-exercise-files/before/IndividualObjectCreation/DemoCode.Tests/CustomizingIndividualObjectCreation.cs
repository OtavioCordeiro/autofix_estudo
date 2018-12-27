using System;
using System.Runtime.InteropServices;
using Ploeh.AutoFixture;
using Xunit;

namespace DemoCode.Tests
{
    public class CustomizingIndividualObjectCreation
    {
        [Fact]
        public void Error()
        {
            var fixture = new Fixture();

            var flight = fixture.Create<FlightDetails>();
        }
    }
}
