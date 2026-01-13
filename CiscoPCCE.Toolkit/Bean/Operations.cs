using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("operations")]
    public class Operations : BaseApiBean
    {
        [XmlElement("operation")]
        public List<Operation>? OperationList { get; set; }
    }
}