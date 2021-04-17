using System;
using System.Collections.Generic;
using System.Linq;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        // Events for when the Farm has been Emptied of Animals
        public delegate void FarmEmptied();  // delegate
        public event FarmEmptied FarmEmpty; // event to be raised

        // A Queue to hold the Farm Animals in the order that they enter the farm
        private Queue<IFarmAnimal> Animals { get; } = new Queue<IFarmAnimal>();

        //TEST 1
        public void Enter(IFarmAnimal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            var animalType = animal.GetType().Name;
            Console.WriteLine($"{animalType} has entered the Emydex farm");
            Animals.Enqueue(animal);
        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            if (Animals.Count == 0) // or !Animals.Any()
            {
                Console.WriteLine("There are no animals in the farm");
                return;
            }

            // For each animal in the farm allow them to make from some
            // The foreach iterator will not dequeue animals from the queue
            foreach (var animal in Animals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            var hasAnAnimalBeenMilked = false;

            // Get all the IMilkableAnimal from the Animals Queue (delay the execution until used)  
            var milkableAnimals = Animals.OfType<IMilkableAnimal>();

            foreach (var milkableAnimal in milkableAnimals)
            {
                milkableAnimal.ProduceMilk();
                hasAnAnimalBeenMilked = true;
            }

            if (!hasAnAnimalBeenMilked)
            {
                Console.WriteLine("Cannot identify the farm animals which can be milked");
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            //Console.WriteLine("There are still animals in the farm, farm is not free");

            // Exercised asked to "simply clear the collection",
            // hence looping though the animals to say that they have left the farm
            // then clearing the Queue (No dequeuing)
            foreach (var animal in Animals)
            {
                var animalType = animal.GetType().Name;
                Console.WriteLine($"{animalType} has left the farm");
            }

            // Exercised asked to "simply clear the collection"
            Animals.Clear();

            //if FarmEmptied is not null then call delegate
            FarmEmpty?.Invoke();
        }
    }
}