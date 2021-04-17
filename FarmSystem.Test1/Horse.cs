﻿using System;

namespace FarmSystem.Test1
{
    public class Horse : FarmAnimal
    {
        public override void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public override void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}