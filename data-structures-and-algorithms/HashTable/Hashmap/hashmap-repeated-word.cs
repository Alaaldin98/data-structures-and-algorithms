using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.HashTable.Hashmap
{
    public class hashmap_repeated_word 
    {
        public static string Repeated(string word)
        {
            word = word.ToLower();
            string[] arrWords = word.Split(' ');
            int count = 0;

            for (int i = 0; i < arrWords.Length; i++)
            {
                for (int j = 0; j < arrWords.Length; j++)
                {
                    if (arrWords[i] == arrWords[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    return arrWords[i];
                }
                count = 0;
            }

            return "No repetition";
        }
    }
}
