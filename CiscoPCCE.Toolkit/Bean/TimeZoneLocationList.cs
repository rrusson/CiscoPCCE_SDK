using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("timezone")
    [XmlRoot("results")]
    public class TimeZoneLocationList : BaseApiBean
    {
        [XmlElement("timeZones")]
        [XmlElement("timeZone")]
        public List<TimeZoneLocation>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("timezone")
        [XmlRoot("results")]
        public class TimeZoneLocationListList : BaseApiListBean<TimeZoneLocationList>
        {
            public override List<TimeZoneLocationList>? GetItems() => Items;

            public override void SetItems(List<TimeZoneLocationList>? value) => Items = value;
        }
    }
}