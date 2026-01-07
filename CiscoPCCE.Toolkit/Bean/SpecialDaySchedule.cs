using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("specialDaySchedule")]
    public class SpecialDaySchedule : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public string? Date { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? EndTime { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        public string? StartTime { get; set; }

        public int? Status { get; set; }

        public required ReferenceBean StatusReason { get; set; }
    }
}