﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo.Classes
{
    class Dolphin : Water
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

        public override bool HasLegs { get; set; } = false;

    }
}
