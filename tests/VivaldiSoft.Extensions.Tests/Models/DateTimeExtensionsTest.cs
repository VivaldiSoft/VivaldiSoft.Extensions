using VivaldiSoft.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xunit;

namespace VivaldiSoft.Extensions.Tests
{
    public class DateTimeExtensionsTest
    {
        [Theory]
        [InlineData("01/01/1970 00:00:00", "en-US", 0)]
        [InlineData("01/01/1970 00:00:00", "es-ES", 0)]
        [InlineData("02/16/2008 12:15:12", "en-US", 1203164112)]
        [InlineData("16/02/2008 12:15:12", "es-ES", 1203164112)]
        public void DateTimeToUnixTimeStamp(string value, string culture, long expected)
        {
            DateTime date = DateTime.Parse(value, new CultureInfo(culture));
            var result = date.DateTimeToUnixTimeStamp();

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, "01/01/1970 00:00:00")]
        [InlineData(1203164112, "02/16/2008 12:15:12")]
        public void UnixTimeStampToDateTime(long value, string expected)
        {
            var result = value.UnixTimeStampToDateTime().ToString("MM/dd/yyyy HH:mm:ss");

            Assert.Equal(expected, result);
        }
    }
}
