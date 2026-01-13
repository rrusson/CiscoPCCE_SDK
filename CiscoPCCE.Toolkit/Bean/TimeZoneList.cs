using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("timezone")
    [XmlRoot("results")]
    public class TimeZoneList : BaseApiList<TimeZone>
    {
        [XmlArray("timeZones")]
        [XmlArrayItem("timeZone")]
        public new List<TimeZone>? Items
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