using FluentAssertions;
using FluentExtensions.Byte;
using FluentExtensions.String;
using NUnit.Framework;

namespace FluentExtensions.Tests.String
{
    [TestFixture]
    public class ToByteArrayFromHexStringTests
    {
        private const string Str = "foo bar";
        [Test]
        public void TestConvertToByteArrayFromHexString()
        {
            var bytes = Str.ToByteArray();
            var hex = bytes.ToHexString();
            var bytesFromHex = hex.ToByteArrayFromHexString();
            var str = bytesFromHex.ToStringFromByteArray();
            str.Should().Be(Str);
        }
         
    }
}