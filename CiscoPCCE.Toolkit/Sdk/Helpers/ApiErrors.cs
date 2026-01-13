using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Sdk.Helpers
{
    /// <summary>
    /// This class defines the entity attached to HTTP response in error conditions
    /// </summary>
    [XmlRoot("apiErrors")]
    public class ApiErrors : BaseBean
    {
        [XmlArray("apiErrors")]
        [XmlArrayItem("apiError")]
        private List<ApiError> _apiErrors;

        public ApiErrors()
        {
            _apiErrors = new List<ApiError>();
        }

        public ApiErrors(List<ApiError> apiErrors)
        {
            this._apiErrors = apiErrors;
        }

        public List<ApiError> GetApiErrors()
        {
            return _apiErrors;
        }
    }
}

/*
Example XML response:
<apiErrors>
    <apiError>
        <errorData>serviceLevelThreshold</errorData>
        <errorDetail>
            <min>1</min>
            <max>2147483647</max>
        </errorDetail>
        <errorMessage>This field must contain a value from 1 to 2147483647</errorMessage>
        <errorType>invalidInput.outOfRange</errorType>
    </apiError>
</apiErrors> 
 */
