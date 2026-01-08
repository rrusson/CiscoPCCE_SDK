using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("database")
    [XmlRoot("results")]
    public class DatabaseList : BaseApiBean
    {
        [XmlArray("databases")]
        [XmlArrayItem("database")]
        public List<Database>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("database")
        [XmlRoot("results")]
        public class DatabaseListList : BaseApiListBean<DatabaseList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<DatabaseList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<DatabaseList>? GetItems() => Items;

            public override void SetItems(List<DatabaseList>? value) => Items = value;
        }
    }
}