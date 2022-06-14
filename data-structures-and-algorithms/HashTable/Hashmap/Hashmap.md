# Challenge Summary
<!-- Description of the challenge -->
Write a function called repeated word that finds the first word to occur more than once in a string

Arguments: string
Return: string
## Whiteboard Process
![Whiteboard](whiteboard.png)
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
This algorithms approach is to split the the string into a list and create a dictionary from each word. It then iterates through that original list incrementing each dictionary key as it is found. If any dictionary keys value reaches two it returns that key.- Time: O(N)
- Space: O(N)
## Solution
<!-- Show how to run your code, and examples of it in action -->
```C#
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
```