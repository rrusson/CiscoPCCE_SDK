using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("apiError")]
    public class ApiError : BaseApiBean
    {
        [XmlElement("errorData")]
        public string? ErrorData { get; set; }

        [XmlElement("errorDetail")]
        public ApiErrorDetail? ErrorDetail { get; set; }

        [XmlElement("errorMessage")]
        public string? ErrorMessage { get; set; }

        [XmlElement("errorType")]
        public string? ErrorType { get; set; }
    }
}