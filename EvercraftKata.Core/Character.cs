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

      public Attribute Strength { get; set; } = 10;
      public Attribute Dexterity { get; set; } = 10;
      public Attribute Constitution { get; set; } = 10;
      public Attribute Wisdom { get; set; } = 10;
      public Attribute Intelligence { get; set; } = 10;
      public Attribute Charisma { get; set; } = 10;

      public bool Attack(Character target, int roll)
      {
         bool isHit =  roll + Strength.Modifier >= target.ArmorClass;

         if (isHit)
         {
            int damage = Math.Max(1, 1 + Strength.Modifier);
            target.HitPoints -= damage;
            if(roll == 20)
            {
               target.HitPoints -= 1; // + Strength.Modifier;
            }
         }

         return isHit;
      }

   }
}
