using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Porthole.Utils
{
    public static class DisplayUtils
    {
        public static string TruncateAtWord(string value, int length = 180)
        {
            if (value == null || value.Length < length || value.IndexOf(" ", length, StringComparison.Ordinal) == -1)
                return value;

            return value.Substring(0, value.IndexOf(" ", length, StringComparison.Ordinal)) + "...";
        }

        public static string GetInitials(string value)
        {
            string initials = Regex.Replace(value, @"[\p{P}\p{S}\p{C}\p{N}]+", "");

            initials = Regex.Replace(initials, @"\p{Z}+", " ");
            initials = Regex.Replace(initials.Trim(), @"\s+(?:[JS]R|I{1,3}|I[VX]|VI{0,3})$", "", RegexOptions.IgnoreCase);
            initials = Regex.Replace(initials, @"^(\p{L})[^\s]*(?:\s+(?:\p{L}+\s+(?=\p{L}))?(?:(\p{L})\p{L}*)?)?$", "$1$2").Trim();

            if (initials.Length > 2)
            {
                initials = initials.Substring(0, 2);
            }

            return initials.ToUpperInvariant();
        }
    }
}
