using System;

namespace FluentExtensions.Byte
{
    /// <summary>
    /// Convert byte array to Hex string
    /// </summary>
    public static class ToHexStringExtension
    {
        /// <summary>
        /// Convert byte array to Hex string.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns></returns>
        public static string ToHexString(this byte[] bytes)
        {
            var hex = BitConverter.ToString(bytes);
            return hex.Replace("-", "");
        }
    }
}