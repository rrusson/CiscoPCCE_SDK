using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationpath")
    [XmlRoot("results")]
    public class ApplicationPathList : BaseApiBean
    {
        [XmlElement("applicationPaths")]
        [XmlElement("applicationPath")]
        public List<ApplicationPath>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

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