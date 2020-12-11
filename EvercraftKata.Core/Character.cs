﻿using System;

namespace EvercraftKata.Core
{
   public class Character
   {
      public string Name { get; set; } = "Name";

      public Alignments Alignment { get; set; } = Alignments.Neutral;

      public int ArmorClass => 10;

      public int HitPoints { get; private set; } = 5;

      public void Attack(Character target) => throw new NotImplementedException();

   }
}
