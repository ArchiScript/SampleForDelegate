using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForDelegate
{
   public class NumberOverFiveException: Exception
    {
        public NumberOverFiveException(string message): base(message)
        {

        }
    }
}
