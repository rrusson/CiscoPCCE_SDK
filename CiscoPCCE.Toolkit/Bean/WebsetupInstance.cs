using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("instance")]
    public class WebsetupInstance : BaseApiBean
    {
        [XmlElement("facilityName")]
        public string? FacilityName { get; set; }

        [XmlElement("instanceName")]
        public string? InstanceName { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}