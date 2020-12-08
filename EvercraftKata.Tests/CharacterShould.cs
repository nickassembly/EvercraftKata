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

      [Fact]
      public void GetAndSetName()
      {
         var name = "Artemis";
         var character = new Character();

         character.Name = name;

         character.Name.Should().Be(name);
      }


   }
}
