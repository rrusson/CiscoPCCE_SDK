using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Feature : BaseApiBean
    {
        [XmlElement("featureName")]
        public string? FeatureName { get; set; }

        [XmlElement("systemDefined")]
        public bool? SystemDefined { get; set; }
    }
}