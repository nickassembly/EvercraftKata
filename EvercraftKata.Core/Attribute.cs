using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvercraftKata.Core
{
   public struct Attribute
   {
      public Attribute(int value)
      {
         Value = value;
      }
      public int Value { get; set; }

      public int Modifier => (Value - 10) / 2;
   }
}
