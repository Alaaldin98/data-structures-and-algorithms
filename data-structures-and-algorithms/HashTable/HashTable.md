# Hashtables
Is a data structure that implements a set abstract data type, a structure that can map keys to values. A hash table uses a hash function to compute an index, also called a hash code, into an array of buckets or slots, from which the desired value can be found. During lookup, the key is hashed and the resulting hash indicates where the corresponding value is stored.
## Challenge
Implement a Hashtable Class with the following methods:

- **set**
Arguments: key, value
Returns: nothing
This method should hash the key, and set the key and value pair in the table, handling collisions as needed.
Should a given key already exist, replace its value from the value argument given to this method.
- **get**
Arguments: key
Returns: Value associated with that key in the table
- **contains**
Arguments: key
Returns: Boolean, indicating if the key exists in the table already.
- **keys**
Returns: Collection of keys
- **hash**
Arguments: key
Returns: Index in the collection for that key

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
Big O(1) space/time
## API
<!-- Description of each method publicly available in each of your hashtable -->
#### hash
```C
 private int hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.length;
            }
            return hash;
        }
```
#### set
```C
  public void set(string key, int value)
        {
            int index = hash(key);
            if (this.data[index] == null)
            {
                this.data[index] = new MyNodes();
            }
            this.data[index].Add(new Myhashtable(key, value));
        }
```
#### get
```C
  public int get(string key)
        {
            int index = hash(key);
            if (this.data[index] == null)
            {
                return 0;
            }
            foreach (var node in this.data[index])
            {
                if (node.key.Equals(key))
                {
                    return node.value;
                }
            }
            return 0;
        }
```
#### keys
```C
  public List<string> keys()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < this.data.Length; i++)
            {
                if (this.data[i] != null)
                {
                    for (int j = 0; j < length; j++)
                    {
                        result.Add(this.data[i][j].key);
                    }
                }
            }
            return result;
        }
```
