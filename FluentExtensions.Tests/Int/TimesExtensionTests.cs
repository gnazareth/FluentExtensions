using FluentAssertions;
using FluentExtensions.Int;
using NUnit.Framework;

namespace FluentExtensions.Tests.Int
{
    [TestFixture]
    public class TimesExtensionTests
    {
        [Test]
        public void TestPositiveIntegerWithoutIndex()
        {
            var sum = 0;
            5.Times(() => sum += 1);
            sum.Should().Be(5);
        }

        [Test]
        public void TestPositiveIntegerWithIndex()
        {
            var sum = 0;
            5.Times(i => sum += i);
            sum.Should().Be(10);
        }

        [Test]
        public void TestZeroIntegerWithoutIndex()
        {
            var sum = 0;
            0.Times(() => sum += 1);
            sum.Should().Be(0);
        }

        [Test]
        public void TestZeroIntegerWithIndex()
        {
            var sum = 0;
            0.Times(i => sum += i);
            sum.Should().Be(0);
        }

        [Test]
        public void TestNegativeIntegerWithoutIndex()
        {
            var sum = 0;
            const int count = -5;
            count.Times(() => sum += 1);
            sum.Should().Be(5);
        }

        [Test]
        public void TestNegativeIntegerWithIndex()
        {
            var sum = 0;
            const int count = -5;
            count.Times(i => sum += i);
            sum.Should().Be(-10);
        }
    }
}