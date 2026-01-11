using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Status : BaseApiBean
    {
        [XmlElement("apiError")]
        public required ApiError ApiError { get; set; }

        [XmlElement("state")]
        public State State { get; set; }
    }
}