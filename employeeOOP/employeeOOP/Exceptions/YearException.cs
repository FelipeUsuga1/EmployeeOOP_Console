using System.Runtime.Serialization;

namespace EmployeeOOP.Exceptions
{
    [Serializable]
    internal class YearException : Exception
    {
        private string v;
        private int year;

        public YearException()
        {
        }

        public YearException(string? message) : base(message)
        {
        }

        public YearException(string v, int year)
        {
            this.v = v;
            this.year = year;
        }

        public YearException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected YearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}