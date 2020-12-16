using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EvercraftKata.Tests
{
   public class AttributeShould
   {
      [Fact]
      public void DefaultToTen()
      {
         var attribute = new Attribute();

         attribute.Value.Should().Be(10);

      }

      [Fact]
      public void HaveSpecificModifierValues()
      {

      }

      public struct Attribute
      {
         public int Value { get; set; }
      }

   }
}
