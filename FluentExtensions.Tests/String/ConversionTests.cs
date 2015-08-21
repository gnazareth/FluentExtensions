using FluentAssertions;
using NUnit.Framework;
using FluentExtensions.String;

namespace FluentExtensions.Tests.String
{
    [TestFixture]
    public class ConversionTests
    {
        [Test]
        public void StringToInt()
        {
            const string myString = "5";
            myString.ToInt().Should().Be(5);
            myString.To<int>().Should().Be(5);
        }

        [Test]
        public void StringToDouble()
        {
            const string myString = "5.1";
            myString.ToDouble().Should().Be(5.1);
            myString.To<double>().Should().Be(5.1);
        }

        [Test]
        public void StringToFloat()
        {
            const string myString = "5.1";
            myString.ToFloat().Should().Be(5.1f);
            myString.To<float>().Should().Be(5.1f);
        }

        [Test]
        public void StringToDecimal()
        {
            const string myString = "5.1";
            myString.ToDecimal().Should().Be(5.1M);
            myString.To<decimal>().Should().Be(5.1M);
        }

        [Test]
        public void StringToLong()
        {
            const string myString = "5";
            myString.ToLong().Should().Be(5);
            myString.To<long>().Should().Be(5);
        }

        [Test]
        public void StringToULong()
        {
            const string myString = "5";
            myString.ToULong().Should().Be(5);
            myString.To<ulong>().Should().Be(5);
        }

        [Test]
        public void StringToBool()
        {
            const string myString = "true";
            myString.ToBool().Should().Be(true);
            myString.To<bool>().Should().Be(true);


            const string myString2 = "false";
            myString2.ToBool().Should().Be(false);
            myString2.To<bool>().Should().Be(false);
        }

        [Test]
        public void StringToChar()
        {
            const string myString = "5";
            myString.ToChar().Should().Be('5');
            myString.To<char>().Should().Be('5');
        }

        [Test]
        public void StringToUInt()
        {
            const string myString = "5";
            myString.ToUInt().Should().Be(5);
            myString.To<uint>().Should().Be(5);
        }

        [Test]
        public void StringToShort()
        {
            const string myString = "5";
            myString.ToShort().Should().Be(5);
            myString.To<short>().Should().Be(5);
        }

        [Test]
        public void StringToUShort()
        {
            const string myString = "5";
            myString.ToUShort().Should().Be(5);
            myString.To<ushort>().Should().Be(5);
        }
    }
}