using Lab05_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    public class Penguin : Feathers , IEatMeat
    {
        public bool Carnivore()
        {
            return true;
        }

        public override string GroupName()
        {
            return "colony";
        }
    }
}
