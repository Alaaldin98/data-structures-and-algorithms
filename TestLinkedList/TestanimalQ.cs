using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using data_structures_and_algorithms.SQ_animal_shelter;

namespace TestLinkedList
{
    public class TestanimalQ
    {
        [Fact]
        public void Test_Dog()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog1 = new Dog();
            animalShelter.Enqueue(dog1);

            Assert.True(animalShelter.Dogs.Dequeue() is Dog);
        }


        [Fact]
        public void Test_Cat()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal cat1 = new Cat();
            animalShelter.Enqueue(cat1);

            Assert.True(animalShelter.Cats.Dequeue() is Cat);
        }


        [Fact]
        public void Test_Dog_Dequeue()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog1 = new Dog();
            animalShelter.Enqueue(dog1);

            Assert.True(animalShelter.Dequeue("dog") is Dog);
        }

        [Fact]
        public void Test_Cat_Dequeue()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal cat1 = new Cat();
            animalShelter.Enqueue(cat1);

            Assert.True(animalShelter.Dequeue("cat") is Cat);
        }
    }
}
