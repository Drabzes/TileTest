using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /// <summary>
    /// Utility class to return new DateTimes every few requests.
    /// </summary>
    public static class DateTimeNowCache
    {
        /// <summary>
        /// Refresh time after this many requests.
        /// </summary>
        const int _count = 20;

        /// <summary>
        /// The most recent time collected.
        /// </summary>
        static DateTime _recentTime = DateTime.Now;

        /// <summary>
        /// Number of skipped time collections
        /// </summary>
        static int _skipped;

        /// <summary>
        /// Get the DateTime within the last N calls.
        /// </summary>
        /// <returns>Recent DateTime collected.</returns>
        public static int GetDateTime()
        {
            _skipped++;
            if (_skipped > _count)
            {
                _recentTime = DateTime.Now;
                _skipped = 0;
            }
            return _recentTime.Millisecond;
        }
    }
}
