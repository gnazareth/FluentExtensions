using FluentAssertions;
using FluentExtensions.String;
using NUnit.Framework;

namespace FluentExtensions.Tests.String
{
    [TestFixture]
    public class LeftExtensionTests
    {
        [Test]
        public void TestStringLeft()
        {
            const string myString = "Foo Bar";
            myString.Left(3).Should().Be("Foo");
        }

        [Test]
        public void TestStringLeftWhenStringIsShorterThanLeftCount()
        {
            const string myString = "Foo";
            myString.Left(5).Should().Be("Foo");
        }

        [Test]
        public void TestStringLeftWhenInputStringIsBlank()
        {
            const string myString = "";
            myString.Left(5).Should().Be("");
        }

        [Test]
        public void TestStringLeftWhenLeftCountIsZero()
        {
            const string myString = "Foo Bar";
            myString.Left(0).Should().Be("");
        }

        [Test]
        public void TestStringLeftWhenLeftCountIsGreaterThanInputLength()
        {
            const string myString = "Foo Bar";
            myString.Left(1000).Should().Be("Foo Bar");
        }
    }
}