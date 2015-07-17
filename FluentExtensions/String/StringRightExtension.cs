namespace FluentExtensions.String
{
    /// <summary>
    /// Returns x characters from the right of a string
    /// </summary>
    public static class StringRightExtension
    {
        /// <summary>
        /// Returns x characters from the right of a string
        /// </summary>
        /// <param name="value">string input</param>
        /// <param name="length">length of substring</param>
        /// <returns></returns>
        public static string Right(this string value, int length)
        {
            return length <= value.Length ? value.Substring(value.Length - length) : value;
        }
    }
}