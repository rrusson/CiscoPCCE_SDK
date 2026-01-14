using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("businessHour")]
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
    }
}