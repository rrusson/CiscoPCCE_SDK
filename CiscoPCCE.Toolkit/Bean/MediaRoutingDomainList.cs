using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("mediaroutingdomain")
    [XmlRoot("results")]
    public class MediaRoutingDomainList : BaseApiBean
    {
        [XmlArray("mediaRoutingDomains")]
        [XmlArrayItem("mediaRoutingDomain")]
        public List<MediaRoutingDomain>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("mediaroutingdomain")
        [XmlRoot("results")]
        public class MediaRoutingDomainListList : BaseApiListBean<MediaRoutingDomainList>
        {
            public override List<MediaRoutingDomainList>? GetItems() => Items;

            public override void SetItems(List<MediaRoutingDomainList>? value) => Items = value;
        }
    }
}