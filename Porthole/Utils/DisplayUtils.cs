using System;
using System.Collections.Generic;
using System.Linq;

namespace Porthole.Utils
{
    public static class DisplayUtils
    {
        public static string TruncateAtWord(string value, int length)
        {
            if (value == null || value.Length < length || value.IndexOf(" ", length, StringComparison.Ordinal) == -1)
                return value;

            return value.Substring(0, value.IndexOf(" ", length, StringComparison.Ordinal)) + "...";
        }

        public static string GetInitials(string value)
        {
            List<string> list = value.Split(' ').Select(t => t.Substring(0, 1)).ToList();
            return String.Join("", list.Count > 2 ? list.Take(2) : list).ToUpper();
        }
    }
}
