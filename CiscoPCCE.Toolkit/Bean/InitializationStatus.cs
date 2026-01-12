using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("initialize")
    [XmlRoot("initializationStatus")]
    public class InitializationStatus : BaseApiBean
    {
        [XmlArray("apiErrors")]
        [XmlArrayItem("apiError")]
        public List<ApiError>? ApiErrors { get; set; }

        [XmlElement("state")]
        public StateEnum State { get; set; }

        [XmlElement("stateString")]
        public string? StateString { get; set; }

        [XmlElement("name")]
        public string? TaskName { get; set; }
        
    }
}