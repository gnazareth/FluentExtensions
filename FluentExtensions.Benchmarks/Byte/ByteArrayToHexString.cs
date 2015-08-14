using System;
using System.Text;
using FluentAssertions;
using FluentExtensions.Byte;
using FluentExtensions.String;
using NUnit.Framework;

namespace FluentExtensions.Benchmarks.Byte
{
    [TestFixture]
    public class ByteArrayToHexString
    {
        private const string Str = "foo bar";

        [Test]
        public void Comparison()
        {
            Helper.DisplayResult("BitConverterMethod", Helper.RepeatMillionTimes(() => BitConverterMethod(Str.ToByteArray())));
            Helper.DisplayResult("StringBuilderMethod", Helper.RepeatMillionTimes(() => StringBuilderMethod(Str.ToByteArray())));
        }


        [Test]
        public void BitConverterMethodTest()
        {
            var bytes = Str.ToByteArray();
            var hex = BitConverterMethod(bytes);
            var bytesFromHex = StringToByteArray(hex);
            var str = bytesFromHex.ToStringFromByteArray();
            str.Should().Be(Str);
        }

        [Test]
        public void StringBuilderMethodTest()
        {
            var bytes = Str.ToByteArray();
            var hex = StringBuilderMethod(bytes);
            var bytesFromHex = StringToByteArray(hex);
            var str = bytesFromHex.ToStringFromByteArray();
            str.Should().Be(Str);
        }

        private static string BitConverterMethod(byte[] bytes)
        {
            var hex = BitConverter.ToString(bytes);
            return hex.Replace("-", "");
        }

        private string StringBuilderMethod(byte[] bytes)
        {
            var hex = new StringBuilder(bytes.Length * 2);
            foreach (var b in bytes) hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
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