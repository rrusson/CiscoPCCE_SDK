using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvruscript")
    [XmlRoot("results")]
    public class NetworkVruScriptList : BaseApiBean
    {
        [XmlArray("networkVruScripts")]
        [XmlArrayItem("networkVruScript")]
        public List<NetworkVruScript>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("networkvruscript")
        [XmlRoot("results")]
        public class NetworkVruScriptListList : BaseApiListBean<NetworkVruScriptList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<NetworkVruScriptList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<NetworkVruScriptList>? GetItems() => Items;

            public override void SetItems(List<NetworkVruScriptList>? value) => Items = value;
        }
    }
}