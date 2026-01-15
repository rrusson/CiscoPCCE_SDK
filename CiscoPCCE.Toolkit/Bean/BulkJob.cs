using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("bulkJob")]
    public class BulkJob : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("createDateTime")]
        public DateTime? CreateDateTime { get; set; }

        [XmlElement("csvFile")]
        public required FileRef CsvFile { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("endDateTime")]
        public DateTime? EndDateTime { get; set; }

        [XmlElement("fileContent")]
        public string? FileContent { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("jobHostName")]
        public string? JobHostName { get; set; }

        [XmlElement("jobState")]
        public short? JobState { get; set; }

        [XmlElement("jobType")]
        public short? JobType { get; set; }

        [XmlElement("logFile")]
        public required FileRef LogFile { get; set; }

        [XmlElement("startDateTime")]
        public DateTime? StartDateTime { get; set; }
    }
}