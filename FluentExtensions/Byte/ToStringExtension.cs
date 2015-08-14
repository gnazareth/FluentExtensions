namespace FluentExtensions.Byte
{
    /// <summary>
    /// Convert byte array to string
    /// </summary>
    public static class ToStringExtension
    {
        /// <summary>
        /// Convert byte array to string.
        /// </summary>
        /// <param name="bytes">The byte array.</param>
        /// <returns></returns>
        public static string ToStringFromByteArray(this byte[] bytes)
        {
            var chars = new char[bytes.Length/sizeof (char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}