using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    public abstract class Animals
    {
        public abstract string Name();

        public abstract bool Dangerous { get; set; }

        public abstract bool WarmBlooded { get; set; }

        public virtual bool Extinct { get; set; }
    }
}
