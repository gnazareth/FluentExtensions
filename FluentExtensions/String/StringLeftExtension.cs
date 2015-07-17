namespace FluentExtensions.String
{
    /// <summary>
    /// Returns x characters from the left of a string
    /// </summary>
    public static class StringLeftExtension
    {
        /// <summary>
        /// Returns x characters from the left of a string
        /// </summary>
        /// <param name="value">string input</param>
        /// <param name="length">length of substring</param>
        /// <returns></returns>
        public static string Left(this string value, int length)
        {
            return length <= value.Length ? value.Substring(0, length) : value;
        }
    }
}