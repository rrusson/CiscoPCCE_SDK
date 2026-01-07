using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("regionprefix")]
    public class RegionPrefix : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required Timestamp DateTimeStamp { get; set; }

        public bool? DaylightSavingEnabled { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? Gmt { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        public int? RegionId { get; set; }

        public string? RegionPrefixValue { get; set; }
    }
}