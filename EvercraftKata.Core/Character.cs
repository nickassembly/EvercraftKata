using System;

namespace EvercraftKata.Core
{
   public class Character
   {
      public string Name { get; set; } = "Name";

      public Alignments Alignment { get; set; } = Alignments.Neutral;

      public int ArmorClass => 10;

      public int HitPoints { get; private set; } = 5;
      public bool IsDead => HitPoints < 1;

      public int Strength { get; set; } = 10;
      public int Dexterity { get; set; } = 10;
      public int Constitution { get; set; } = 10;
      public int Wisdom { get; set; } = 10;
      public int Intelligence { get; set; } = 10;
      public int Charisma { get; set; } = 10;

      public bool Attack(Character target, int roll)
      {
         bool isHit =  roll >= target.ArmorClass;

         if (isHit)
         {
            target.HitPoints--;
            if(roll == 20)
            {
               target.HitPoints--;
            }
         }

         return isHit;
      }

   }
}
