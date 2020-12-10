using EvercraftKata.Core;
using FluentAssertions;
using System;
using Xunit;

namespace EvercraftKata.Tests
{
   public class CharacterShould
   {
      [Fact]
      public void HaveDefaultValuesAtCreation()
      {
         var character = new Character();

         character.Name.Should().Be("Name");
         character.Alignment.Should().Be(Alignments.Neutral);
      }

      [Theory]
      [InlineData("Artemis", Alignments.Good)]
      [InlineData("Harry", Alignments.Neutral)]
      [InlineData("Horrible", Alignments.Evil)]
      public void GetAndSetNameAndAlignment(string name, Alignments alignment)
      {
         var character = new Character();

         character.Name = name;
         character.Alignment = alignment;

         character.Name.Should().Be(name);
         character.Alignment.Should().Be(alignment);
      }


   }
}
