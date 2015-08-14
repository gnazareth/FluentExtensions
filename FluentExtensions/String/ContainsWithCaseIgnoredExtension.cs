using System;

namespace FluentExtensions.String
{
    /// <summary>
    /// Determines whether substring is contained in value. Case is ignored.
    /// </summary>
    public static class ContainsWithCaseIgnoredExtension
    {
        /// <summary>
        /// Determines whether substring is contained in value. Case is ignored.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="subString">The sub string.</param>
        /// <returns></returns>
        public static bool ContainsWithCaseIgnored(this string value, string subString)
        {
            return value.IndexOf(subString, StringComparison.CurrentCultureIgnoreCase) != -1;
        }
    }
}