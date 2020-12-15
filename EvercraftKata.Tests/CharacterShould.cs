using EvercraftKata.Core;
using FluentAssertions;
using System;
using Xunit;

namespace EvercraftKata.Tests
{
   public class CharacterShould
   {
      private readonly Character _character;

      public CharacterShould()
      {
         _character = new Character();
      }

      [Fact]
      public void HaveDefaultValuesAtCreation()
      {
         _character.Name.Should().Be("Name");
         _character.Alignment.Should().Be(Alignments.Neutral);
         _character.ArmorClass.Should().Be(10);
         _character.HitPoints.Should().Be(5);
      }

      [Theory]
      [InlineData("Artemis", Alignments.Good)]
      [InlineData("Harry", Alignments.Neutral)]
      [InlineData("Horrible", Alignments.Evil)]
      public void GetAndSetNameAndAlignment(string name, Alignments alignment)
      {
         _character.Name = name;
         _character.Alignment = alignment;
         _character.Name.Should().Be(name);
         _character.Alignment.Should().Be(alignment);
      }

      [Theory]
      [InlineData(8, false)]
      [InlineData(9, false)]
      [InlineData(10, true)]
      [InlineData(11, true)]
      public void AttackTargetCharacters(int roll, bool expected)
      {
         var target = new Character();
         bool result = _character.Attack(target, roll);

         result.Should().Be(expected);
      }

      [Theory]
      [InlineData(8, false, 5)]
      [InlineData(9, false, 5)]
      [InlineData(10, true, 4)]
      [InlineData(11, true, 4)]
      [InlineData(20, true, 3)]
      public void DamageTargetOnAttackHit(int roll, bool isHit, int expectedHitPoints)
      {
         var target = new Character();
         target.HitPoints.Should().Be(5);

         bool result = _character.Attack(target, roll);

         result.Should().Be(isHit);
         target.HitPoints.Should().Be(expectedHitPoints);
      }





   }
}
