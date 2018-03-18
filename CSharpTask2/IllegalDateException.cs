using System;

namespace CSharpTask2
{
    class IllegalDateException : Exception
    {
        private string _trace;

        public string Trace
        {
            get { return _trace; }
            private set { _trace = value; }
        }

        public IllegalDateException() : base()
        {
            Trace = "";
        }

        public IllegalDateException(string message) : base(message)
        {
            Trace = message;
        }

        public override string ToString()
        {
            return "\nIllegal date exception!\n" + _trace;
        }
    }
}
