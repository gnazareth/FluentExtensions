using FluentAssertions;
using FluentExtensions.String;
using NUnit.Framework;

namespace FluentExtensions.Tests.String
{
    [TestFixture]
    public class RightExtensionTests
    {
        [Test]
        public void TestStringRight()
        {
            const string myString = "Foo Bar";
            myString.Right(3).Should().Be("Bar");
        }

        [Test]
        public void TestStringRightWhenStringIsShorterThanRightCount()
        {
            const string myString = "Foo";
            myString.Right(5).Should().Be("Foo");
        }

        [Test]
        public void TestStringRightWhenInputStringIsBlank()
        {
            const string myString = "";
            myString.Right(5).Should().Be("");
        }

        [Test]
        public void TestStringRightWhenRightCountIsZero()
        {
            const string myString = "Foo Bar";
            myString.Right(0).Should().Be("");
        }

        [Test]
        public void TestStringRightWhenRightCountIsGreaterThanInputLength()
        {
            const string myString = "Foo Bar";
            myString.Right(1000).Should().Be("Foo Bar");
        }
    }
}