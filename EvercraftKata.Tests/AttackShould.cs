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
      [InlineData(1, 4)]
      [InlineData(2, 4)]
      [InlineData(9, 4)]
      [InlineData(20, -1)]
      [InlineData(18, 0)]
      [InlineData(12, 3)]
      public void AdjustAttackDamageByStrengthModifier(int strength, int expectedHitPoints)
      {
         _character.Strength = strength;
         var target = new Character();
         target.HitPoints.Should().Be(5);

        _character.Attack(target, 19);

         target.HitPoints.Should().Be(expectedHitPoints);
      }

      [Theory]
      [InlineData(1, 4)]
      [InlineData(2, 4)]
      [InlineData(9, 4)]
      [InlineData(20, -7)]
      [InlineData(18, -5)]
      [InlineData(15, -1)]
      [InlineData(12, 1)]
      public void DoubleDamageForCriticalHits(int strength, int expectedHitPoints)
      {
         _character.Strength = strength;
         var target = new Character();
         target.HitPoints.Should().Be(5);

         _character.Attack(target, 20);

         target.HitPoints.Should().Be(expectedHitPoints);
      }

   }
}
