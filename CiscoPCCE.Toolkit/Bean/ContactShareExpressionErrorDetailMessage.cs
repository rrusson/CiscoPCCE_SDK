using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharerule")
    [XmlRoot("expressionError")]
    public class ContactShareExpressionErrorDetailMessage : BaseApiBean
    {
        [XmlElement("data")]
        public string? Data { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }
    }
}