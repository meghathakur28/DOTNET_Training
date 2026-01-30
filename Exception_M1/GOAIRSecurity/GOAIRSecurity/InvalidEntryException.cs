using System;
using System.Collections.Generic;
using System.Text;

namespace GOAIRSecurity
{
    public class InvalidEntryException:Exception
    {
        public InvalidEntryException() { }
        public InvalidEntryException(string message) : base(message) { }
    }
}
