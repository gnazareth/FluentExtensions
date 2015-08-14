using System;
using System.Diagnostics;

namespace FluentExtensions.Benchmarks
{
    public static class Helper
    {
        public static Func<Action, long> Time = action =>
        {
            var watch = Stopwatch.StartNew();
            action.Invoke();
            watch.Stop();
            return watch.ElapsedMilliseconds;
        };

        public static Func<int, Action, long> Repeat = (count, action) =>
        {
            return Time(() =>
            {
                for (var i = 0; i < count; i++) action.Invoke();
            });
        };

        public static Func<Action, long> RepeatMillionTimes = (action) =>
        {
            return Time(() =>
            {
                for (var i = 0; i < 1000000; i++) action.Invoke();
            });
        };

        public static void DisplayResult(string method, long time)
        {
            Debug.Print("{0}: {1} ms.", method, time);
        }
    }
}