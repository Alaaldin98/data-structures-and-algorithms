using System.Collections.Generic;

namespace data_structures_and_algorithms.HashTable
{

    public class Node
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Node Next { get; set; }

        public Node(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
    public class HashTables
    {
        private static int tableSize;
        public Node[] Table { get; set; }

        public HashTables(int size)
        {
            tableSize = size;
            Table = new Node[tableSize];
        }

        public int hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % 1024;
            }
            return hash;
        }

        public void Set(string key, string value)
        {
            int index = hash(key);
            Node newNode = new Node(key, value);

            if (Table[index] == null)
            {
                Table[index] = newNode;
            }
            else
            {
                Node current = Table[index];
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(key, value);
            }
        }

        public Node Get(string key)
        {
            int index = hash(key);
            Node current = Table[index];

            while (current != null)
            {
                if (current.Key == key)
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }

        public List<string> keys()
        {
            List<string> KeyList = new List<string>();
            for (int i = 0; i < Table.Length; i++)
            {
                if (Table[i] != null)
                {
                    KeyList.Add(Table[i].Key);
                }
            }
            return KeyList;

        }
        public bool Contains(string key)
        {
            int index = hash(key);
            Node current = Table[index];

            while (current != null)
            {
                if (current.Key == key)
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }
    }
}
