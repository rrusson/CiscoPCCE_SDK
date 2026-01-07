using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvruscript")
    [XmlRoot("results")]
    public class NetworkVruScriptList : BaseApiBean
    {
        [XmlElement("networkVruScripts")]
        [XmlElement("networkVruScript")]
        public List<NetworkVruScript>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

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