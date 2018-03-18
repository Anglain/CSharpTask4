using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    class IllegalEmailException : Exception
    {
        private string _trace;

        public string Trace
        {
            get { return _trace; }
            private set { _trace = value; }
        }

        public IllegalEmailException() : base()
        {
            Trace = "";
        }

        public IllegalEmailException(string message) : base(message)
        {
            Trace = message;
        }

        public override string ToString()
        {
            return "\nIllegal email exception!\n" + _trace;
        }
    }
}
