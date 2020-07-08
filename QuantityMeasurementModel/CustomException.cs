namespace QuantityMeasurementModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CustomException : Exception
    {
        /// <summary>
        /// This is enum constant exception
        /// </summary>
        public enum ExceptionType
        {
            INPUT_NULL, TYPE_NOT_MATCH, OPTIONS_NOT_MATCH, NULL_EXCEPTION
        }
        public ExceptionType type;

        /// <summary>
        /// Parameterized constructors
        /// </summary>
        /// <param name="type"></param>
        public CustomException(ExceptionType type)
        {
            this.type = type;
        }

        /// <summary>
        /// Exception method
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public CustomException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}