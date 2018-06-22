using Lab05_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    public class SeaOtter : Water , IEatMeat
    {
        public override string Name()
        {
            return "Otter";
        }

        public override bool Dangerous { get; set; } = false;

        public override bool WarmBlooded { get; set; } = true;

        public override string GroupName()
        {
            return "family";
        }

        public override string Sound()
        {
            return "chirp";
        }

        public bool Carnivore()
        {
            return true;
        }

        public override bool HasLegs { get; set; } = false;
    }
}
