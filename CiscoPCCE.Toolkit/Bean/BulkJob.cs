using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("bulkjob")
    [XmlRoot("bulkJob")]
    public class BulkJob : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public DateTime? CreateDateTime { get; set; }

        public required FileRef CsvFile { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public DateTime? EndDateTime { get; set; }

        public string? FileContent { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? JobHostName { get; set; }

        public short? JobState { get; set; }

        public short? JobType { get; set; }

        public required FileRef LogFile { get; set; }

        public new string? RefURL { get; set; }

        public DateTime? StartDateTime { get; set; }

        // Path("bulkjob")
        [XmlRoot("results")]
        public class BulkJobList : BaseApiListBean<BulkJob>
        {
            public override List<BulkJob>? GetItems() => Items;

            public override void SetItems(List<BulkJob>? value) => Items = value;
        }
    }
}