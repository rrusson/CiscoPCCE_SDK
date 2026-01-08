using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("masterscript")
    [XmlRoot("results")]
    public class MasterScriptList : BaseApiBean
    {
        [XmlArray("masterScripts")]
        [XmlArrayItem("masterScript")]
        public List<MasterScript>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("masterscript")
        [XmlRoot("results")]
        public class MasterScriptListList : BaseApiListBean<MasterScriptList>
        {
            public override List<MasterScriptList>? GetItems() => Items;

            public override void SetItems(List<MasterScriptList>? value) => Items = value;
        }
    }
}