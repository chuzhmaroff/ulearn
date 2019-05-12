﻿namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            if (count < 10 || count > 20 && count < 100)
            {
                int rem = count % 10;
                return (rem > 1 && rem < 5) ? "рубля" : ((rem > 4 || rem == 0) ? "рублей" : "рубль");
            }

            if (count < 100) ;
            else count %= 100;
            if (count < 10 || count > 20 && count < 100)
            {
                int rem = count % 10;
                return (rem > 1 && rem < 5) ? "рубля" : ((rem > 4 || rem == 0) ? "рублей" : "рубль");
            }
            return "рублей";
        }
    }
}