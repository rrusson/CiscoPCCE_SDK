using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class NetworkLabelGlobalSetting : BaseApiBean
    {
        [XmlElement("cmLabel")]
        public string? CMLabel { get; set; }

        [XmlArray("cvpLabels")]
        [XmlArrayItem("cvpLabel")]
        public List<CVPLabel>? CVPLabels { get; set; }

        [XmlElement("outboundLabel")]
        public string? OutboundLabel { get; set; }
    }
}