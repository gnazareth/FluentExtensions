using FluentAssertions;
using FluentExtensions.String;
using NUnit.Framework;

namespace FluentExtensions.Tests.String
{
    [TestFixture]
    public class StringToByteArrayTests
    {
        private const string Str = "foo Bar";

        [Test]
        public void TestConvertToByteArray()
        {
            var bytes = Str.ToByteArray();
            var str = ToStringFromByteArray(bytes);
            str.Should().Be(Str);
        }

        private string ToStringFromByteArray(byte[] bytes)
        {
            var chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}