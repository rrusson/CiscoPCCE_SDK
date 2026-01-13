using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("database")
    [XmlRoot("results")]
    public class DatabaseList : BaseApiList<Database>
    {
        [XmlArray("databases")]
        [XmlArrayItem("database")]
        public new List<Database>? Items
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