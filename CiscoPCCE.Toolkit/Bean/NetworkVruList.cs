using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvru")
    [XmlRoot("results")]
    public class NetworkVruList : BaseApiBean
    {
        [XmlArray("networkVrus")]
        [XmlArrayItem("networkVru")]
        public List<NetworkVru>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("networkvru")
        [XmlRoot("results")]
        public class NetworkVruListList : BaseApiListBean<NetworkVruList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<NetworkVruList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<NetworkVruList>? GetItems() => Items;

            public override void SetItems(List<NetworkVruList>? value) => Items = value;
        }
    }
}