using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("timezone")
    [XmlRoot("results")]
    public class TimeZoneList : BaseApiBean
    {
        [XmlArray("timeZones")]
        [XmlArrayItem("timeZone")]
        public List<TimeZone>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("timezone")
        [XmlRoot("results")]
        public class TimeZoneListList : BaseApiListBean<TimeZoneList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<TimeZoneList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<TimeZoneList>? GetItems() => Items;

            public override void SetItems(List<TimeZoneList>? value) => Items = value;
        }
    }
}