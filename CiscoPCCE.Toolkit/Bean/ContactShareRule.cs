using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharerule")
    [XmlRoot("contactShareRule")]
    public class ContactShareRule : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("ruleExpression")]
        public string? RuleExpression { get; set; }

        // Path("contactsharerule")
        [XmlRoot("results")]
        public class ContactShareRuleList : BaseApiListBean<ContactShareRule>
        {
            [XmlArray("contactShareRules")]
            [XmlArrayItem("contactShareRule")]
            public new List<ContactShareRule>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ContactShareRule>? GetItems() => Items;

            public override void SetItems(List<ContactShareRule>? value) => Items = value;
        }
    }
}