using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshour")
    [XmlRoot("businessHour")]
    public class BusinessHour : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public required BusinessHourConfiguredStatus ConfiguredStatus { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public int? RunTimeStatus { get; set; }

        public string? RunTimeStatusReason { get; set; }

        [XmlElement("specialDaySchedules")]
        [XmlElement("specialDaySchedule")]
        public List<SpecialDaySchedule>? SpecialDaySchedules { get; set; }

        public required ReferenceBean Timezone { get; set; }

        public int? Type { get; set; }

        [XmlElement("weekDaySchedules")]
        [XmlElement("weekDaySchedule")]
        public List<WeekDaySchedule>? WeekDaySchedules { get; set; }

        // Path("businesshour")
        [XmlRoot("results")]
        public class BusinessHourList : BaseApiListBean<BusinessHour>
        {
            public override List<BusinessHour>? GetItems() => Items;

            public override void SetItems(List<BusinessHour>? value) => Items = value;
        }
    }
}