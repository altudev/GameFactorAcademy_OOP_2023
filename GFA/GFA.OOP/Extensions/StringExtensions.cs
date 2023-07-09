using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Extensions
{
    public static class StringExtensions
    {
        public static int ConvertStringToLevel(this string levelText)
        {
            int level = 0;

            if (!int.TryParse(levelText, out level))
                return 0;

            return level;

        }
    }
}
