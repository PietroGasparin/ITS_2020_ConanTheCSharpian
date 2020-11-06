﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConanTheCSharpian.Core
{
    public class Skeleton : Monster
    {
        public Skeleton()
        {
            Name = "Gigi";
            Damage = 14;
            MaxHealth = 70;
            Accuracy = 0.5f;
            Maxmana = 80;
        }

        public override void PerformSpecialAction()
        {
            // TODO: implement special action logic
            Battlefield.DisplayMessage($"{FullyQualifiedName} just used his special action!");
        }
    }
}
