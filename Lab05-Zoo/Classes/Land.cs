using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    public abstract class Land : Mammals
    {
        public abstract bool Domesticated { get; set; }
    }
}
