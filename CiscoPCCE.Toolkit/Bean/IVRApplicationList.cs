using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("transferablefiles")
    [XmlRoot("results")]
    public class IVRApplicationList : BaseApiBean
    {
        [XmlArray("ivrapplications")]
        [XmlArrayItem("ivrapplication")]
        public List<IVRApplication>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("transferablefiles")
        [XmlRoot("results")]
        public class IVRApplicationListList : BaseApiListBean<IVRApplicationList>
        {
            public override List<IVRApplicationList>? GetItems() => Items;

            public override void SetItems(List<IVRApplicationList>? value) => Items = value;
        }
    }
}