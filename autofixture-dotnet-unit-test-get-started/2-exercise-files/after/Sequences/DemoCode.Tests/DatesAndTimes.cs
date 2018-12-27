﻿using System;
using Ploeh.AutoFixture;
using Xunit;

namespace DemoCode.Tests
{
    public class DatesAndTimes
    {
        [Fact]
        public void DateTimes()
        {
            // arrange
            var fixture = new Fixture();
            DateTime logTime = fixture.Create<DateTime>();

            // act
            LogMessage result = LogMessageCreator.Create(fixture.Create<string>(), logTime);

            // assert
            Assert.Equal(result.Year, logTime.Year);
        }


        [Fact]
        public void TimeSpans()
        {
            var fixture = new Fixture();

            TimeSpan span = fixture.Create<TimeSpan>();
        }

    }
}
