using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class ResourceErrorDetail : BaseApiBean
    {
        [XmlElement("apiErrors")]
        public required ApiErrors ApiErrors { get; set; }

        [XmlElement("changeSetElement")]
        public required ChangeSetElement ChangeSetElement { get; set; }

    }
}