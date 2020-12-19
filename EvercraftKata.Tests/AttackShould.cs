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

      [Fact]
      public void AdjustAttackRollByStrengthModifier()
      {
         _character.Strength = 1;

         bool result = _character.Attack(new Character(), 14);

         result.Should().Be(false);
      }
   }
}
