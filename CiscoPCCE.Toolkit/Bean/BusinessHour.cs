using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshour")
    [XmlRoot("businessHour")]
    public class BusinessHour : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("configuredStatus")]
        public required BusinessHourConfiguredStatus ConfiguredStatus { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("runTimeStatus")]
        public int? RunTimeStatus { get; set; }

        [XmlElement("runTimeStatusReason")]
        public string? RunTimeStatusReason { get; set; }

        [XmlArray("specialDaySchedules")]
        [XmlArrayItem("specialDaySchedule")]
        public List<SpecialDaySchedule>? SpecialDaySchedules { get; set; }

        [XmlElement("timezone")]
        public required ReferenceBean Timezone { get; set; }

        [XmlElement("type")]
        public int? Type { get; set; }

        [XmlArray("weekDaySchedules")]
        [XmlArrayItem("weekDaySchedule")]
        public List<WeekDaySchedule>? WeekDaySchedules { get; set; }

        // Path("businesshour")
        [XmlRoot("results")]
        public class BusinessHourList : BaseApiListBean<BusinessHour>
        {
            [XmlArray("businessHours")]
            [XmlArrayItem("businessHour")]
            public new List<BusinessHour>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<BusinessHour>? GetItems() => Items;

            public override void SetItems(List<BusinessHour>? value) => Items = value;
        }
    }
}