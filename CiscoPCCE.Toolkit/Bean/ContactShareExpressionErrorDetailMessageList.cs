using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharerule")
    [XmlRoot("results")]
    public class ContactShareExpressionErrorDetailMessageList : BaseApiList<ContactShareExpressionErrorDetailMessage>
    {
        [XmlArray("expressionErrors")]
        [XmlArrayItem("expressionError")]
        public new List<ContactShareExpressionErrorDetailMessage>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}