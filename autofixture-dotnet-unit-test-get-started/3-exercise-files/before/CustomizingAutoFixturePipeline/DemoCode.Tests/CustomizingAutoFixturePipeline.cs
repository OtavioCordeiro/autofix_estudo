﻿using System.Collections.Generic;
using Ploeh.AutoFixture;
using Xunit;

namespace DemoCode.Tests
{
    public class CustomizingAutoFixturePipeline
    {
        [Fact]
        public void Error()
        {
            var fixture = new Fixture();

            var flight = fixture.Create<FlightDetails>();
        }


    }
}
