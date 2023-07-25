﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public abstract class Mammal : Animal
    {
        public string FurColor;
        public abstract void Walk();

        public override string AnimalType => "Mammal";

        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }

    }
}