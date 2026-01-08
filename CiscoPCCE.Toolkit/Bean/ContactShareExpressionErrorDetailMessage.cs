using System.Xml.Serialization;

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

        // Path("contactsharerule")
        [XmlRoot("results")]
        public class ContactShareExpressionErrorDetailMessageList : BaseApiListBean<ContactShareExpressionErrorDetailMessage>
        {
            [XmlArray("expressionErrors")]
            [XmlArrayItem("expressionError")]
            public new List<ContactShareExpressionErrorDetailMessage>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ContactShareExpressionErrorDetailMessage>? GetItems() => Items;

            public override void SetItems(List<ContactShareExpressionErrorDetailMessage>? value) => Items = value;
        }
    }
}