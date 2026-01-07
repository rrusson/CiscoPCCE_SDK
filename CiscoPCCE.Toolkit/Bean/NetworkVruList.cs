using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvru")
    [XmlRoot("results")]
    public class NetworkVruList : BaseApiBean
    {
        [XmlElement("networkVrus")]
        [XmlElement("networkVru")]
        public List<NetworkVru>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("networkvru")
        [XmlRoot("results")]
        public class NetworkVruListList : BaseApiListBean<NetworkVruList>
        {
            public override List<NetworkVruList>? GetItems() => Items;

            public override void SetItems(List<NetworkVruList>? value) => Items = value;
        }
    }
}