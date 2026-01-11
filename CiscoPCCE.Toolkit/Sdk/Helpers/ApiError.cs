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
            ErrorData = data;
            ErrorMessage = message;
			ErrorType = type;
		}

		[XmlElement("errorData")]
		public string? ErrorData { get; set; }

        [XmlElement]
        public string? ErrorMessage { get; set; }

		[XmlElement("errorType")]
		public string? ErrorType { get; set; }
	}
}
