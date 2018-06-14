using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    public abstract class Mammals : Animals
    {
        public abstract string GroupName();

        public abstract string Sound();

        public virtual bool LiveBirth { get; set; } = true;

    }
}
