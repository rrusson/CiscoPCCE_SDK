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
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<ApplicationPathList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ApplicationPathList>? GetItems() => Items;

            public override void SetItems(List<ApplicationPathList>? value) => Items = value;
        }
    }
}