# hashmap left join
Implement a simplified LEFT JOIN for 2 Hashmaps.


Write a function that LEFT JOINs two hashmaps into a single data structure.

## Approach & Efficiency
Create a method that accepts 2 hash maps as a parameter. Declare a list and iterate through each hashmap and compare the keys if it matches. If each hash map has the same key, then add the key and values to the list, otherwise add to list with the second hash map value to null.

#### Time O(n)	
#### Space O(1)

### Whiteboard
![Hashmap Left Join](hashmap-left-join.jpg)
