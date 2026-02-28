using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Prog7311_POE_Part2
{
    public static class LanguageManager
    {
        public static string CurrentLanguage = "en-ZA"; // default

        public static void SetLanguage(string cultureCode)

        {
            CurrentLanguage = cultureCode;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureCode);
        }
    }
}
