using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.HashTable.Hashmap
{
    public class hashmap_repeated_word 
    {
        public string HashmapRepeatedWord(string Word)
        {
           
          
            var Value = Word.Split(' ');  // Split the string using 'Space' and stored it an var variable  
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
            for (int i = 0; i < Value.Length; i++) //loop the splited string  
            {
                if (RepeatedWordCount.ContainsKey(Value[i])) // Check if word already exist in dictionary update the count  
                {
                    int value = RepeatedWordCount[Value[i]];
                    RepeatedWordCount[Value[i]] = value + 1;
                }
                else
                {
                    RepeatedWordCount.Add(Value[i], 1);  // if a string is repeated and not added in dictionary , here we are adding   
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Repeated words");
            foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)
            {
                Console.WriteLine(kvp.Key);  // Print the Repeated word
                return kvp.Key;
            }
            return "";
        }
    }
}
