using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using data_structures_and_algorithms.HashTable.Hashmap;


namespace TestLinkedList.HashTable
{
    public class hashrepeatedTests
    {
        [Fact]
        public void Test1()
        {
            string word = "Once upon a time, there was a brave princess who";

            Assert.Equal("a", hashmap_repeated_word.Repeated(word));
        }
        [Fact]
        public void Test2()
        {
            string word = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way � in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only";

            Assert.Equal("it", hashmap_repeated_word.Repeated(word));
        }

        [Fact]
        public void Test3()
        {
            string word = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn�t know what I was doing in New York";

            Assert.Equal("was", hashmap_repeated_word.Repeated(word));
        }
    }
}
