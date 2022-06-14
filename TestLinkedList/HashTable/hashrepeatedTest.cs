﻿using data_structures_and_algorithms.HashTable.Hashmap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestLinkedList.HashTable
{
    public class hashrepeatedTest
    {
        hashmap_repeated_word hashmapRepeatedWord = new hashmap_repeated_word();
        [Fact]
        public void Test1()
        {
            string text = "";
            Assert.Equal("", hashmapRepeatedWord.HashmapRepeatedWord(text));
        }
        [Fact]
        public void Test2()
        {
            string text = "Once upon a time, there was brave princess who";
            Assert.Equal("", hashmapRepeatedWord.HashmapRepeatedWord(text));
        }
        [Fact]
        public void Test3()
        {
            string text = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            Assert.Equal("It", hashmapRepeatedWord.HashmapRepeatedWord(text));
        }
        [Fact]
        public void Test4()
        {
            string text = "It was a queer sultry summer, It is they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York";
            Assert.Equal("It", hashmapRepeatedWord.HashmapRepeatedWord(text));
        }  
    }
}
