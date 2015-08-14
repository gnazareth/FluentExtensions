using FluentAssertions;
using NUnit.Framework;

namespace FluentExtensions.Benchmarks.String
{
    [TestFixture]
    public class StringToByteArray
    {
        private const string Str = "Foo Bar";

        [Test]
        public void Comparison()
        {
            Helper.DisplayResult("BlockCopyMethod", Helper.RepeatMillionTimes(() => BlockCopyMethod(Str)));
            Helper.DisplayResult("EncodingMethod", Helper.RepeatMillionTimes(() => EncodingMethod(Str)));
        }

        [Test]
        public void BlockCopyMethodTest()
        {
            var bytes = BlockCopyMethod(Str);
            var str = ToStringFromByteArray(bytes);
            str.Should().Be(Str);
        }

        [Test]
        public void EncodingMethodTest()
        {
            var bytes = EncodingMethod(Str);
            var str = System.Text.Encoding.UTF8.GetString(bytes);
            str.Should().Be(Str);
        }

        private static byte[] BlockCopyMethod(string str)
        {
            var bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private static byte[] EncodingMethod(string str)
        {
            return System.Text.Encoding.UTF8.GetBytes(str);
        }

        public string ToStringFromByteArray(byte[] bytes)
        {
            var chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}