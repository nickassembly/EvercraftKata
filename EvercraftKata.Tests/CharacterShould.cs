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

      [Fact]
      public void AttackTargetCharacters()
      {

      }


   }
}
