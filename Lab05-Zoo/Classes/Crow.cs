using Lab05_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lab05_Zoo.Classes
{
    public class Crow : Feathers , IFly
    {
        public bool Fly()
        {
            return true;
        }

        public override string GroupName()
        {
            return "Murder";
        }

        public override string Sound()
        {
            return "Caw";
        }


    }
}
