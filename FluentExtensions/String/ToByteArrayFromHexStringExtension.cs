using System;

namespace FluentExtensions.String
{
    /// <summary>
    /// Convert Hex string to Byte Array
    /// </summary>
    public static class ToByteArrayFromHexStringExtension
    {
        /// <summary>
        /// Convert Hex string to Byte Array.
        /// </summary>
        /// <param name="hex">The hexadecimal.</param>
        /// <returns></returns>
        public static byte[] ToByteArrayFromHexString(this string hex)
        {
            var length = hex.Length;
            var bytes = new byte[length / 2];
            for (var i = 0; i < length; i += 2) bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}