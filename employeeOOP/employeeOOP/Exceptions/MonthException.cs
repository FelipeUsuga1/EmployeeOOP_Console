using System.Runtime.Serialization;

namespace EmployeeOOP.Exceptions
{
    [Serializable]
    internal class MonthException : Exception
    {
        private string v;
        private int month;

        public MonthException()
        {
        }

        public MonthException(string? message) : base(message)
        {
        }

        public MonthException(string v, int month)
        {
            this.v = v;
            this.month = month;
        }

        public MonthException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MonthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}