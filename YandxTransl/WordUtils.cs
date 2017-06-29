using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandxTransl
{
    class WordUtils
    {
        public static string[] splitIntoWords(string text)
        {
            return text.Split(' ');
        }
    }
}
