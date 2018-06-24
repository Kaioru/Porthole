using System;

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
    }
}
