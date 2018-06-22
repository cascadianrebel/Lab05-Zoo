using Lab05_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lab05_Zoo.Classes
{
    public class Bat : Land , IFly
    {
        public override string Name()
        {
            return "Dolphin";
        }

        public override bool Dangerous { get; set; } = false;

        public override bool WarmBlooded { get; set; } = true;

        public override string GroupName()
        {
            return "pod";
        }

        public override string Sound()
        {
            return "eeeeeeee";
        }

        public bool Fly()
        {
            return true;
        }

        public override bool Domesticated { get; set; } = false;
    }
}
