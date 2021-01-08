﻿using System;
using System.Runtime.Serialization;

namespace SystemRejestracjiWPrzychodni
{
    [Serializable]
    internal class WrongDateException : Exception
    {
        public WrongDateException()
        {
        }

        public WrongDateException(string message) : base(message)
        {
        }

        public WrongDateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongDateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}