using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("database")
    [XmlRoot("results")]
    public class DatabaseList : BaseApiBean
    {
        [XmlElement("databases")]
        [XmlElement("database")]
        public List<Database>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("database")
        [XmlRoot("results")]
        public class DatabaseListList : BaseApiListBean<DatabaseList>
        {
            public override List<DatabaseList>? GetItems() => Items;

            public override void SetItems(List<DatabaseList>? value) => Items = value;
        }
    }
}