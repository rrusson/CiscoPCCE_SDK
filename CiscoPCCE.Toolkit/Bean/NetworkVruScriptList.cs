using System.Xml.Serialization;

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
            public override List<NetworkVruScriptList>? GetItems() => Items;

            public override void SetItems(List<NetworkVruScriptList>? value) => Items = value;
        }
    }
}