using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("systemValidationStatus")]
    public class SystemValidationStatus : BaseApiBean
    {
        [XmlElement("isValid")]
        public bool? IsValid { get; set; }

        [XmlArray("validationRules")]
        [XmlArrayItem("validationRule")]
        public List<SystemValidationRuleResult>? SystemValidationResult { get; set; }

        [XmlElement("vmValidationResult")]
        public required VMValidationResult VmValidationResult { get; set; }
    }
}