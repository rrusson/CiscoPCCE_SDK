using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationpath")
    [XmlRoot("applicationPathMember")]
    public class ApplicationPathMember : BaseApiBean
    {
        public int? ApplicationPathId { get; set; }

        public int? MrDomainId { get; set; }

        public short? PeripheralId { get; set; }

        // Path("applicationpath")
        [XmlRoot("results")]
        public class ApplicationPathMemberList : BaseApiListBean<ApplicationPathMember>
        {
            public override List<ApplicationPathMember>? GetItems() => Items;

            public override void SetItems(List<ApplicationPathMember>? value) => Items = value;
        }
    }
}