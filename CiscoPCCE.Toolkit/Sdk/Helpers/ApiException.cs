namespace CiscoPCCE.Toolkit.Sdk.Helpers
{
    /// <summary>
    /// Exception class that contains API Errors.
    /// If the errors can be unmarshalled, they are stored in the ApiErrors property.
    /// If not, the returned text is found in the Message property.
    /// </summary>
    public class ApiException : Exception
    {
        public ApiException(string message) : base(message)
        {
        }

        public ApiException(ApiErrors errors)
        {
            Errors = errors;
        }

        public ApiErrors? Errors { get; }

        public override string Message
        {
            get
            {
                if (Errors != null)
                {
                    return System.Text.Json.JsonSerializer.Serialize(Errors);
                }

                return base.Message;
            }
        }
    }
}
