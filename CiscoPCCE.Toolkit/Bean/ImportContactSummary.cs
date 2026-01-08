using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("importContactSummary")]
    public class ImportContactSummary : BaseApiBean
    {
        [XmlElement("accountNumber")]
        public string? AccountNumber { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("callResultOverall")]
        public int CallResultOverall { get; set; }

        [XmlElement("callStatus")]
        public CallStatusEnum CallStatusEnum { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("firstName")]
        public string? FirstName { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("lastName")]
        public string? LastName { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}