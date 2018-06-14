using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    public abstract class Reptiles : Animals
    {
        public abstract string Exterior();

        public virtual bool LaysEggs { get; set; } = true;

    }
}
