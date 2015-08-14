namespace FluentExtensions.String
{
    /// <summary>
    /// Converts string to byte array
    /// </summary>
    public static class StringToByteArrayExtension
    {
        /// <summary>
        /// Converts string to byte array.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static byte[] ToByteArray(this string value)
        {
            var bytes = new byte[value.Length * sizeof(char)];
            System.Buffer.BlockCopy(value.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}