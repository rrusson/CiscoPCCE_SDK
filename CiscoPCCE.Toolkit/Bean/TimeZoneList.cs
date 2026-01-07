using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("timezone")
    [XmlRoot("results")]
    public class TimeZoneList : BaseApiBean
    {
        [XmlElement("timeZones")]
        [XmlElement("timeZone")]
        public List<TimeZone>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("timezone")
        [XmlRoot("results")]
        public class TimeZoneListList : BaseApiListBean<TimeZoneList>
        {
            public override List<TimeZoneList>? GetItems() => Items;

            public override void SetItems(List<TimeZoneList>? value) => Items = value;
        }
    }
}