using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharerule")
    [XmlRoot("contactShareRule")]
    public class ContactShareRule : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public string? RuleExpression { get; set; }

        // Path("contactsharerule")
        [XmlRoot("results")]
        public class ContactShareRuleList : BaseApiListBean<ContactShareRule>
        {
            public override List<ContactShareRule>? GetItems() => Items;

            public override void SetItems(List<ContactShareRule>? value) => Items = value;
        }
    }
}