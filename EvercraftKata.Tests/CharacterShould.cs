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
   }
}
