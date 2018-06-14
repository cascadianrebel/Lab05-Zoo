using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    class Snake : Scales
    {
        public override string Name()
        {
            return "Snake";
        }

        public override bool Dangerous { get; set; } = true;

        public override bool WarmBlooded { get; set; } = false;

        public sealed override string Exterior()
        {
            return "scales";
        }

        public sealed override bool HasLegs { get; set; } = false;
    }
}
