using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using FluentAssertions;
using FluentExtensions.Int;
using NUnit.Framework;

namespace FluentExtensions.Benchmarks.String
{
    [TestFixture]
    public class StringContainsWithCaseIgnored
    {
        private const string Value = "FOO BAR";
        private const string SubString = "foo";
        private const int Iterations = 1000000;

        [Test]
        public void Comparisons()
        {
            Debug.Print("Determining if \"{0}\" is contained in \"{1}\" {2} times.\n", SubString, Value, Iterations);
            Helper.DisplayResult("IndexOfPlusStringComparisonMethod", Helper.Repeat(Iterations, () => IndexOfPlusStringComparisonMethod()));
            Helper.DisplayResult("RegexMethod", Helper.Repeat(Iterations, () => RegexMethod()));
            Helper.DisplayResult("ToLowerCasePlusStringComparisonMethod", Helper.Repeat(Iterations, () => ToLowerCasePlusStringComparisonMethod()));
        }

        [Test]
        public void IndexOfPlusStringComparisonMethodTest()
        {
            IndexOfPlusStringComparisonMethod().Should().BeTrue();
        }

        [Test]
        public void RegexMethodTest()
        {
            RegexMethod().Should().BeTrue();
        }

        [Test]
        public void ToLowerCasePlusStringComparisonMethodTest()
        {
            ToLowerCasePlusStringComparisonMethod().Should().BeTrue();
        }

        private bool IndexOfPlusStringComparisonMethod()
        {
            return Value.IndexOf(SubString, StringComparison.CurrentCultureIgnoreCase) != -1;
        }

        private bool RegexMethod()
        {
            return Regex.IsMatch(Value, SubString, RegexOptions.IgnoreCase);
        }

        private bool ToLowerCasePlusStringComparisonMethod()
        {
            return Value.ToLower().Contains(SubString.ToLower());
        }
    }
}