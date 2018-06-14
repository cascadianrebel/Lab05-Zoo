using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    public abstract class Scales : Reptiles
    {
        public abstract bool HasLegs { get; set; }

        public virtual bool ForkedTongue { get; set; } = true;

        public virtual string Sound()
        {
            return "hissssss";
        }
    }
}
