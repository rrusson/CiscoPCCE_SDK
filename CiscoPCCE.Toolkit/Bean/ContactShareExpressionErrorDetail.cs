using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharerule")
    [XmlRoot("errorDetail")]
    public class ContactShareExpressionErrorDetail : BaseApiBean
    {
        [XmlArray("expressionErrors")]
        [XmlArrayItem("expressionError")]
        public List<ContactShareExpressionErrorDetailMessage>? ExpressionErrors { get; set; }
    }
}