using VivaldiSoft.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VivaldiSoft.Extensions.Tests
{
    public class ByteExtensionsTest
    {
        [Theory]
        [ClassData(typeof(BytesToHexaData))]
        public void BytesToHexa(byte[] value, string separator, string expected)
        {
            var result = value.BytesToHexa(separator);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(HexaToBytesData))]
        public void HexaToBytes(string value, string separator, byte[] expected)
        {
            var result = value.HexaToBytes(separator);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(BytesToStringData))]
        public void BytesToString(byte[] value, string expected)
        {
            var result = value.BytesToString();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void BytesToString_Exception_value_Null()
        {
            byte[] value = null;

            Assert.Throws<ArgumentNullException>(() => ByteExtensions.BytesToString(value));
        }

        [Theory]
        [ClassData(typeof(StringToBytesData))]
        public void StringToBytes(string value, byte[] expected)
        {
            var result = value.StringToBytes();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void StringToBytes_Exception_value_Null()
        {
            string value = null;

            Assert.Throws<ArgumentNullException>(() => ByteExtensions.StringToBytes(value));
        }

        public class BytesToHexaData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new byte[] { }, "", "" };
                yield return new object[] { new byte[] { 48, 49, 50, 51, 52 }, "", "3031323334" };
                yield return new object[] { new byte[] { 48, 49, 50, 51, 52 }, "-", "30-31-32-33-34" };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class HexaToBytesData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { "", "", new byte[] { } };
                yield return new object[] { "3031323334", "", new byte[] { 48, 49, 50, 51, 52 } };
                yield return new object[] { "30-31-32-33-34", "-", new byte[] { 48, 49, 50, 51, 52 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class BytesToStringData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new byte[] { }, "" };
                yield return new object[] { new byte[] { 48, 49, 50, 51, 52 }, "01234" };
                yield return new object[] { new byte[] { 97, 98, 99, 100, 101 }, "abcde" };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class StringToBytesData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { "", new byte[] { } };
                yield return new object[] { "01234", new byte[] { 48, 49, 50, 51, 52 } };
                yield return new object[] { "abcde", new byte[] { 97, 98, 99, 100, 101 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
