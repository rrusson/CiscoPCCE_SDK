using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("logcollection")
    [XmlRoot("results")]
    public class LogCollectionList : BaseApiBean
    {
        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("logcollection")
        [XmlRoot("results")]
        public class LogCollectionListList : BaseApiListBean<LogCollectionList>
        {
            public override List<LogCollectionList>? GetItems() => Items;

            public override void SetItems(List<LogCollectionList>? value) => Items = value;
        }
    }
}