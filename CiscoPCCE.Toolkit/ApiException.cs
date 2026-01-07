using System;

namespace CiscoPCCE.Toolkit
{
    /// <summary>
    /// Exception class that contains API Errors.
    /// If the errors can be unmarshalled, they are stored in the ApiErrors property.
    /// If not, the returned text is found in the Message property.
    /// </summary>
    public class ApiException : Exception
    {
        private readonly ApiErrors? errors;

        public ApiException()
        {
        }

        public ApiException(string message) : base(message)
        {
        }

        public ApiException(ApiErrors errors)
        {
            this.errors = errors;
        }

        public ApiErrors? Errors => errors;

        public override string Message
        {
            get
            {
                if (errors != null)
                {
                    return System.Text.Json.JsonSerializer.Serialize(errors);
                }
                return base.Message;
            }
        }
    }
}
