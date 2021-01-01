using EvercraftKata.Core;
using FluentAssertions;

namespace EvercraftKata.Tests.Extensions
{
   public static class CharacterExtensions
   {
      public static void SetLevel(this Character character, int level)
      {
         character.ExperiencePoints = (level - 1) * Character.ExperiencePerLevel;
         character.Level.Should().Be(level);
      }
   }
}
