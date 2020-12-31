using EvercraftKata.Core;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EvercraftKata.Tests
{
   public class AttackShould
   {
      private readonly Character _character;

      public AttackShould()
      {
         _character = new Character();
      }

      [Theory]
      [InlineData(1, 14, false)]
      [InlineData(1, 15, true)]
      [InlineData(2, 14, true)]
      [InlineData(20, 5, true)]
      [InlineData(20, 4, false)]
      [InlineData(12, 8, false)]
      [InlineData(12, 9, true)]
      public void AdjustAttackRollByStrengthModifier(int strength, int roll, bool expected)
      {
         _character.Strength = strength;

         bool result = _character.Attack(new Character(), roll);

         result.Should().Be(expected);
      }

      [Theory]
      [InlineData(1, 1)]
      [InlineData(2, 1)]
      [InlineData(9, 1)]
      [InlineData(20, 6)]
      [InlineData(18, 5)]
      [InlineData(12, 2)]
      public void AdjustAttackDamageByStrengthModifier(int strength, int expectedDamage)
      {
         _character.Strength = strength;
         var target = new Character();
         target.Damage.Should().Be(0);

        _character.Attack(target, 19);

         target.Damage.Should().Be(expectedDamage);
      }

      [Theory]
      [InlineData(1, 1)]
      [InlineData(2, 1)]
      [InlineData(9, 1)]
      [InlineData(20, 12)]
      [InlineData(18, 10)]
      [InlineData(15, 6)]
      [InlineData(12, 4)]
      public void DoubleDamageForCriticalHits(int strength, int expectedDamage)
      {
         _character.Strength = strength;
         var target = new Character();
         target.Damage.Should().Be(0);

         _character.Attack(target, 20);

         target.Damage.Should().Be(expectedDamage);
      }

      [Theory]
      [InlineData(0, 10)]
      [InlineData(10, 20)]
      [InlineData(15, 25)]
      public void IncreaseAttackerExperienceOnHit(int startExp, int expected)
      {
         _character.ExperiencePoints = startExp;

         _character.Attack(new Character(), 18).Should().BeTrue();

         _character.ExperiencePoints.Should().Be(expected);
      }


   }
}
