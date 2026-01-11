using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Sdk.Helpers
{
    /// <summary>
    /// This class defines the entity attached to HTTP response in error conditions
    /// </summary>
    [XmlRoot("apiError")]
    public class ApiError : BaseBean
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ApiError()
        {
        }

        public ApiError(string type, string data, string message)
        {
            ErrorType = type;
            ErrorData = data;
            ErrorMessage = message;
        }

        public string? ErrorType { get; set; }

        public string? ErrorData { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
