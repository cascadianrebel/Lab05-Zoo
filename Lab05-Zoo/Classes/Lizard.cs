using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    class Lizard : Scales
    {
        public override string Name()
        {
            return "Lizard";
        }

        public override bool Dangerous { get; set; } = false;

        public override bool WarmBlooded { get; set; } = false;

        public sealed override string Exterior()
        {
            return "scales";
        }

        public override bool HasLegs { get; set; } = true;
    }
}
