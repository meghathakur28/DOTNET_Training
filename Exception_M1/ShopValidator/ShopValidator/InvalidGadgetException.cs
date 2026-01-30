using System;
using System.Collections.Generic;
using System.Text;

namespace ShopValidator
{
    public class InvalidGadgetException:Exception
    {
        public InvalidGadgetException() { }
        public InvalidGadgetException(string message) : base(message) { }
    }
}
