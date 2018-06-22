using System;
using System.Collections.Generic;
using System.Text;
using Lab05_Zoo.Interfaces;

namespace Lab05_Zoo.Classes
{
    public class Owl : Feathers , IFly , IEatMeat
    {
        public bool Carnivore()
        {
            return true;
        }

        public bool Fly()
        {
            return true;
        }

        public override string GroupName()
        {
            return "Parliament";
        }

        public override string Sound()
        {
            return "hooo";
        }


    }
}
