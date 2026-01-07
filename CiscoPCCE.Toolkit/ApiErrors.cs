using System.Collections.Generic;
using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit
{
    /// <summary>
    /// This class defines the entity attached to HTTP response in error conditions
    /// </summary>
    [XmlRoot("apiErrors")]
    public class ApiErrors : BaseBean
    {
        [XmlElement("apiError")]
        private readonly List<ApiError> apiErrors;

        public ApiErrors()
        {
            apiErrors = new List<ApiError>();
        }

        public ApiErrors(List<ApiError> apiErrors)
        {
            this.apiErrors = apiErrors;
        }

        public List<ApiError> GetApiErrors()
        {
            return apiErrors;
        }
    }
}
