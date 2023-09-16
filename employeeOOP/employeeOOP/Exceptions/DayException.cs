using System.Runtime.Serialization;

namespace EmployeeOOP.Exceptions
{
    [Serializable]
    internal class DayException : Exception
    {
        private string v;
        private int month;

        public DayException()
        {
        }

        public DayException(string? message) : base(message)
        {
        }

        public DayException(string v, int month)
        {
            this.v = v;
            this.month = month;
        }

        public DayException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}