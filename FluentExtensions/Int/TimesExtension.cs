using System;

namespace FluentExtensions.Int
{
    /// <summary>
    /// Performs an action based on the int value
    /// </summary>
    public static class TimesExtension
    {
        /// <summary>
        /// Loops the specified action based on the int value.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <param name="action">The action.</param>
        public static void Times(this int count, Action action)
        {
            if (count >= 0) for (var i = 0; i < count; i++) action();
            else for (var i = 0; i > count; i--) action();
        }

        /// <summary>
        /// Loops the specified action based on the int value. Passes the zero based count index.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <param name="action">The action.</param>
        public static void Times(this int count, Action<int> action)
        {
            if (count >= 0) for (var i = 0; i < count; i++) action(i);
            else for (var i = 0; i > count; i--) action(i);
        }
    }
}