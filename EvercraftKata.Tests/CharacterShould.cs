using EvercraftKata.Core;
using FluentAssertions;
using System;
using Xunit;

namespace EvercraftKata.Tests
{
   public class CharacterShould
   {
      [Fact]
      public void HaveDefaultNameAtCreation()
      {
         var character = new Character();

         character.Name.Should().Be("Name");
      }

      [Theory]
      [InlineData("Artemis")]
      [InlineData("Harry")]
      public void GetAndSetName(string name)
      {
         var character = new Character();

         character.Name = name;

         character.Name.Should().Be(name);
      }

      [Theory]
      [InlineData(Alignments.Evil)]
      [InlineData(Alignments.Neutral)]
      [InlineData(Alignments.Good)]
      public void GetAndSetAlignment(Alignments alignment)
      {
         var character = new Character();

         character.Alignment = alignment;

         character.Alignment.Should().Be(alignment);
      }


   }
}
