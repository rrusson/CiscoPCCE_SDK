using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharerule")
    [XmlRoot("errorDetail")]
    public class ContactShareExpressionErrorDetail : BaseApiBean
    {
        [XmlElement("expressionErrors")]
        [XmlElement("expressionError")]
        public List<ContactShareExpressionErrorDetailMessage>? ExpressionErrors { get; set; }

        // Path("contactsharerule")
        [XmlRoot("results")]
        public class ContactShareExpressionErrorDetailList : BaseApiListBean<ContactShareExpressionErrorDetail>
        {
            public override List<ContactShareExpressionErrorDetail>? GetItems() => Items;

            public override void SetItems(List<ContactShareExpressionErrorDetail>? value) => Items = value;
        }
    }
}