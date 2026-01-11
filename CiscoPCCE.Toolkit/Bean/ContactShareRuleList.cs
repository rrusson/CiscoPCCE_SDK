using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharerule")
    [XmlRoot("results")]
    public class ContactShareRuleList : BaseApiBean
    {
        [XmlArray("contactShareRules")]
        [XmlArrayItem("contactShareRule")]
        public List<ContactShareRule>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("contactsharerule")
        [XmlRoot("results")]
        public class ContactShareRuleListList : BaseApiListBean<ContactShareRuleList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<ContactShareRuleList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ContactShareRuleList>? GetItems() => Items;

            public override void SetItems(List<ContactShareRuleList>? value) => Items = value;
        }
    }
}