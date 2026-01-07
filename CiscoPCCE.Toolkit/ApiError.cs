using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit
{
    /// <summary>
    /// This class defines the entity attached to HTTP response in error conditions
    /// </summary>
    [XmlRoot("apiError")]
    public class ApiError : BaseBean
    {
        private string? errorType;
        private string? errorData;
        private string? errorMessage;

        /// <summary>
        /// Constructor
        /// </summary>
        public ApiError()
        {
        }

        public ApiError(string type, string data, string message)
        {
            this.errorType = type;
            this.errorData = data;
            this.errorMessage = message;
        }

        public string? ErrorType
        {
            get => errorType;
            set => errorType = value;
        }

        public string? ErrorData
        {
            get => errorData;
            set => errorData = value;
        }

        public string? ErrorMessage
        {
            get => errorMessage;
            set => errorMessage = value;
        }
    }
}
