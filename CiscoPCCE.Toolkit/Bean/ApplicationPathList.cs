using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationpath")
    [XmlRoot("results")]
    public class ApplicationPathList : BaseApiBean
    {
        [XmlArray("applicationPaths")]
        [XmlArrayItem("applicationPath")]
        public List<ApplicationPath>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("applicationpath")
        [XmlRoot("results")]
        public class ApplicationPathListList : BaseApiListBean<ApplicationPathList>
        {
            public override List<ApplicationPathList>? GetItems() => Items;

            public override void SetItems(List<ApplicationPathList>? value) => Items = value;
        }
    }
}