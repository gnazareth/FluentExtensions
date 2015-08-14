using FluentAssertions;
using FluentExtensions.String;
using NUnit.Framework;

namespace FluentExtensions.Tests.String
{
    [TestFixture]
    public class StringContainsWithCaseIgnoredTests
    {
        private const string Value = "FoO bAr";

        [Test]
        public void TestSameCase()
        {
            Value.ContainsWithCaseIgnored("FoO").Should().BeTrue();
        }

        [Test]
        public void TestDifferentCase()
        {
            Value.ContainsWithCaseIgnored("foo").Should().BeTrue();
        }

        [Test]
        public void TestNotSubstring()
        {
            Value.ContainsWithCaseIgnored("food").Should().BeFalse();
        }
    }
}