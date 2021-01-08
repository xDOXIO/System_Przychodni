using System;
using System.Runtime.Serialization;

namespace SystemRejestracjiWPrzychodni
{
    [Serializable]
    internal class DoctorWithoutSpecializationException : Exception
    {
        public DoctorWithoutSpecializationException()
        {
        }

        public DoctorWithoutSpecializationException(string message) : base(message)
        {
        }

        public DoctorWithoutSpecializationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DoctorWithoutSpecializationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}