using System;
using System.Collections.Generic;
using System.Text;

namespace VuonSenDa.Utilities.Exceptions
{
    public class VuonSenDaException : Exception
    {
        public VuonSenDaException()
        {
        }

        public VuonSenDaException(string message)
            : base(message)
        {
        }

        public VuonSenDaException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
