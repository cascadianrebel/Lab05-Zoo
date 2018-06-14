using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    class SeaOtter : Water
    {
        public override string Name()
        {
            return "Otter";
        }

        public override bool Dangerous { get; set; } = false;

        public override bool WarmBlooded { get; set; } = true;

        public override string GroupName()
        {
            return "family";
        }

        public override string Sound()
        {
            return "chirp";
        }

        public override bool HasLegs { get; set; } = false;
    }
}
