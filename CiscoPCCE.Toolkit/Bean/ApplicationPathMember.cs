using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationpath")
    [XmlRoot("applicationPathMember")]
    public class ApplicationPathMember : BaseApiBean
    {
        [XmlElement("applicationPathId")]
        public int? ApplicationPathId { get; set; }

        [XmlElement("mrDomainId")]
        public int? MrDomainId { get; set; }

        [XmlElement("peripheralId")]
        public short? PeripheralId { get; set; }

        // Path("applicationpath")
        [XmlRoot("results")]
        public class ApplicationPathMemberList : BaseApiListBean<ApplicationPathMember>
        {
            [XmlArray("applicationPathMembers")]
            [XmlArrayItem("applicationPathMember")]
            public new List<ApplicationPathMember>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ApplicationPathMember>? GetItems() => Items;

            public override void SetItems(List<ApplicationPathMember>? value) => Items = value;
        }
    }
}