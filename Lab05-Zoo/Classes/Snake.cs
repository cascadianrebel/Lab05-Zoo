using System;
using System.Collections.Generic;
using System.Text;
using Lab05_Zoo.Interfaces;

namespace Lab05_Zoo.Classes
{
    public class Snake : Scales , IEatMeat
    {
        public override string Name()
        {
            return "Snake";
        }

        public override bool Dangerous { get; set; } = true;

        public override bool WarmBlooded { get; set; } = false;

        public sealed override string Exterior()
        {
            return "scales";
        }

        public bool Carnivore()
        {
            return true;
        }

        public sealed override bool HasLegs { get; set; } = false;
    }
}
