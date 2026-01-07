using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("weekDaySchedule")]
    public class WeekDaySchedule : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public int? DayOfWeek { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? EndTime { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        public string? StartTime { get; set; }
    }
}