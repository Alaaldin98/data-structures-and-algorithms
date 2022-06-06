using System.Collections.Generic;

namespace data_structures_and_algorithms.HashTable
{
    public class Myhashtable
    {
        public string key { get; set; }
        public int value { get; set; }

        public Myhashtable(string key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }

    class HashTables
    {
        private class MyNodes : List<Myhashtable> { }
        private int length;
        private MyNodes[] data;

        public HashTables(int size)
        {
            this.length = size;
            this.data = new MyNodes[size];
        }

        private int hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.length;
            }
            return hash;
        }

        public void set(string key, int value)
        {
            int index = hash(key);
            if (this.data[index] == null)
            {
                this.data[index] = new MyNodes();
            }
            this.data[index].Add(new Myhashtable(key, value));
        }

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
    }
}
