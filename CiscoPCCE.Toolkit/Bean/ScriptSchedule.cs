using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class ScriptSchedule : BaseApiBean
    {
        [XmlElement("baseUrl")]
        public string? BaseUrl { get; set; }

        [XmlElement("day")]
        public int? Day { get; set; }

        [XmlElement("dayPosition")]
        public DayPosition DayPosition { get; set; }

        [XmlElement("dayType")]
        public DayType DayType { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("endDate")]
        public DateTime? EndDate { get; set; }

        [XmlElement("endTime")]
        public DateTime? EndTime { get; set; }

        [XmlElement("masterScript")]
        public required ReferenceBean MasterScript { get; set; }

        [XmlElement("month")]
        public int? Month { get; set; }

        [XmlElement("scheduleType")]
        public ScheduleType ScheduleType { get; set; }

        [XmlElement("startDate")]
        public DateTime? StartDate { get; set; }

        [XmlElement("startTime")]
        public DateTime? StartTime { get; set; }

        [XmlArray("weekDays")]
        [XmlArrayItem("weekDay")]
        public List<int?>? WeekDays { get; set; }
    }
}