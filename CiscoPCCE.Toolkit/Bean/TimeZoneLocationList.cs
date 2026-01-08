using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("timezone")
    [XmlRoot("results")]
    public class TimeZoneLocationList : BaseApiBean
    {
        [XmlArray("timeZones")]
        [XmlArrayItem("timeZone")]
        public List<TimeZoneLocation>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
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