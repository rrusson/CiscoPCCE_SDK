using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("operations")]
    public class Operations : BaseApiBean
    {
        [XmlElement("operation")]
        public List<Operation>? OperationList { get; set; }
    }
}