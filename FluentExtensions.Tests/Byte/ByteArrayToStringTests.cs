using FluentAssertions;
using FluentExtensions.Byte;
using FluentExtensions.String;
using NUnit.Framework;

namespace FluentExtensions.Tests.Byte
{
    [TestFixture]
    public class ByteArrayToStringTests
    {
        private const string Str = "foo bar";

        [Test]
        public void BasicTest()
        {
            var bytes = Str.ToByteArray();
            var str = bytes.ToStringFromByteArray();
            str.Should().Be(Str);
        }
    }
}