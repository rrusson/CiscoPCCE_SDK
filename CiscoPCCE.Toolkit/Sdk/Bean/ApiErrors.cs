using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    /// <summary>
    /// This class defines the entity attached to HTTP response in error conditions
    /// </summary>
    [XmlType("apiErrors")]
    public class ApiErrors : BaseApiBean
    {
        [XmlArray("apiErrors")]
        [XmlArrayItem("apiError")]
        public List<ApiError> Errors { get; set; } = [];
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
