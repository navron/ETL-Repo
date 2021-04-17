﻿using System;

namespace FarmSystem.Test1
{
    public class Sheep : FarmAnimal
    {
        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }

        public override void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }
}