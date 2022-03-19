using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BKLib
{
    public static class StringExt
    {
        //Adds random text at the end of a string.
        public static string AddRandomText(this string s, int amount)
        {
            string rt = string.Empty;

            for (int i = 0; i < amount; i++)
            {
                rt += (char)Random.Range(65, 91);
            }
            return s + rt;
        }

        public static string CutString(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        

    }
}

