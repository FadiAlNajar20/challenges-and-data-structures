using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures
{
    public class ReverseWords
    {
        public static string Reverse_Words(string word)
        {
            string[] storWord = word.Split(' ');
            string[] result = new string[storWord.Length];

            for (int i = storWord.Length - 1; i >= 0; i--)
            {
                result[storWord.Length - 1 - i] = storWord[i];
            }
            return string.Join(" ", result);
        }
    }
}
