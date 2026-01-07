using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("timezone")
    [XmlRoot("timezone")]
    public class TimeZoneLocation : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? DisplayName { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        // Path("timezone")
        [XmlRoot("results")]
        public class TimeZoneLocationList : BaseApiListBean<TimeZoneLocation>
        {
            public override List<TimeZoneLocation>? GetItems() => Items;

            public override void SetItems(List<TimeZoneLocation>? value) => Items = value;
        }
    }
}