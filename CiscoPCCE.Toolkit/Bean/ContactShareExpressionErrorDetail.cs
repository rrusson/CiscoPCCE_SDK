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

        // Path("contactsharerule")
        [XmlRoot("results")]
        public class ContactShareExpressionErrorDetailList : BaseApiListBean<ContactShareExpressionErrorDetail>
        {
            [XmlArray("errorDetails")]
            [XmlArrayItem("errorDetail")]
            public new List<ContactShareExpressionErrorDetail>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ContactShareExpressionErrorDetail>? GetItems() => Items;

            public override void SetItems(List<ContactShareExpressionErrorDetail>? value) => Items = value;
        }
    }
}