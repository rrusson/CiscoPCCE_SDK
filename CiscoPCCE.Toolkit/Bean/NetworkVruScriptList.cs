using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvruscript")
    [XmlRoot("results")]
    public class NetworkVruScriptList : BaseApiList<NetworkVruScript>
    {
        [XmlArray("networkVruScripts")]
        [XmlArrayItem("networkVruScript")]
        public new List<NetworkVruScript>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}