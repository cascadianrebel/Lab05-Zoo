using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    public class Feathers : Reptiles
    {
        public override string Name()
        {
            return "Bird";
        }

        public override bool Dangerous { get; set; }  = false;

        public override bool WarmBlooded { get; set; } = false;

        public override string Exterior()
        {
            return "feathers";
        }

        public virtual string Sound()
        {
            return "chirp";
        }

        public virtual string GroupName()
        {
            return "flock";
        }
    }
}
