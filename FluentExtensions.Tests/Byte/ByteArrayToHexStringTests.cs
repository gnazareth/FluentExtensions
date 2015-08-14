using System;
using FluentAssertions;
using FluentExtensions.Byte;
using FluentExtensions.String;
using NUnit.Framework;

namespace FluentExtensions.Tests.Byte
{
    [TestFixture]
    public class ByteArrayToHexStringTests
    {
        private const string Str = "foo bar";
        [Test]
        public void TestConvertByteArrayToHexString()
        {
            var bytes = Str.ToByteArray();
            var hex = bytes.ToHexString();
            var bytesFromHex = StringToByteArray(hex);
            var str = bytesFromHex.ToStringFromByteArray();
            str.Should().Be(Str);
        }

        private static byte[] StringToByteArray(string hex)
        {
            var length = hex.Length;
            var bytes = new byte[length / 2];
            for (var i = 0; i < length; i += 2) bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}