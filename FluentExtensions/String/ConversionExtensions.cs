using System;

namespace FluentExtensions.String
{
    /// <summary>
    /// Convert strings to other C# types through a fluent interface
    /// </summary>
    public static class ConversionExtensions
    {
        /// <summary>
        /// Convert string to int.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static int ToInt(this string val) { return int.Parse(val); }
        /// <summary>
        /// Convert string to double.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static double ToDouble(this string val) { return double.Parse(val); }
        /// <summary>
        /// Convert string to float.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static float ToFloat(this string val) { return float.Parse(val); }
        /// <summary>
        /// Convert string to decimal.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static decimal ToDecimal(this string val) { return decimal.Parse(val); }
        /// <summary>
        /// Convert string to long.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static long ToLong(this string val) { return long.Parse(val); }
        /// <summary>
        /// Convert string to ulong.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static ulong ToULong(this string val) { return ulong.Parse(val); }
        /// <summary>
        /// Convert string to bool.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static bool ToBool(this string val) { return bool.Parse(val); }
        /// <summary>
        /// Convert string to char.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static char ToChar(this string val) { return char.Parse(val); }
        /// <summary>
        /// Convert string to uint.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static uint ToUInt(this string val) { return uint.Parse(val); }
        /// <summary>
        /// Convert string to short.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static short ToShort(this string val) { return short.Parse(val); }
        /// <summary>
        /// Convert string to ushort.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static ushort ToUShort(this string val) { return ushort.Parse(val); }

        /// <summary>
        /// Convert string to type provided.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public static T To<T>(this string val)
        {
            var type = typeof(T);
            if (type == typeof (string)) return (T) Convert.ChangeType(val, typeof (T));
            if (type == typeof (int)) return (T) Convert.ChangeType(val.ToInt(), typeof (T));
            if (type == typeof (double)) return (T) Convert.ChangeType(val.ToDouble(), typeof (T));
            if (type == typeof (float)) return (T) Convert.ChangeType(val.ToFloat(), typeof (T));
            if (type == typeof (decimal)) return (T) Convert.ChangeType(val.ToDecimal(), typeof (T));
            if (type == typeof (long)) return (T) Convert.ChangeType(val.ToLong(), typeof (T));
            if (type == typeof(ulong)) return (T)Convert.ChangeType(val.ToULong(), typeof(T));
            if (type == typeof(bool)) return (T)Convert.ChangeType(val.ToBool(), typeof(T));
            if (type == typeof(char)) return (T)Convert.ChangeType(val.ToChar(), typeof(T));
            if (type == typeof(uint)) return (T)Convert.ChangeType(val.ToUInt(), typeof(T));
            if (type == typeof(short)) return (T)Convert.ChangeType(val.ToShort(), typeof(T));
            if (type == typeof(ushort)) return (T)Convert.ChangeType(val.ToUShort(), typeof(T));
            return (T)Convert.ChangeType(null, typeof(T));
        }
    }
}