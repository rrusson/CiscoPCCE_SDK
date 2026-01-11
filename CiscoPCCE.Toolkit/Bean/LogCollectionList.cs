using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<LogCollectionList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<LogCollectionList>? GetItems() => Items;

            public override void SetItems(List<LogCollectionList>? value) => Items = value;
        }
    }
}