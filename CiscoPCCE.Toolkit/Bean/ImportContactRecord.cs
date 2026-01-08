using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("importContact")]
    public class ImportContactRecord : BaseApiBean
    {
        [XmlElement("accountNumber")]
        public string? AccountNumber { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("callResultOverall")]
        public int CallResultOverall { get; set; }

        [XmlElement("callStatus")]
        public CallStatusEnum CallStatusEnum { get; set; }

        [XmlElement("callsMade")]
        public int CallsMade { get; set; }

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

        [XmlElement("importDate")]
        public DateTime? ImportDate { get; set; }

        [XmlElement("lastName")]
        public string? LastName { get; set; }

        [XmlElement("phone01")]
        public required PhoneFields Phone01Fields { get; set; }

        [XmlElement("phone02")]
        public required PhoneFields Phone02Fields { get; set; }

        [XmlElement("phone03")]
        public required PhoneFields Phone03Fields { get; set; }

        [XmlElement("phone04")]
        public required PhoneFields Phone04Fields { get; set; }

        [XmlElement("phone05")]
        public required PhoneFields Phone05Fields { get; set; }

        [XmlElement("phone06")]
        public required PhoneFields Phone06Fields { get; set; }

        [XmlElement("phone07")]
        public required PhoneFields Phone07Fields { get; set; }

        [XmlElement("phone08")]
        public required PhoneFields Phone08Fields { get; set; }

        [XmlElement("phone09")]
        public required PhoneFields Phone09Fields { get; set; }

        [XmlElement("phone10")]
        public required PhoneFields Phone10Fields { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("import")
        [XmlRoot("results")]
        public class ImportContactRecordList : BaseApiListBean<ImportContactRecord>
        {
            public override List<ImportContactRecord>? GetItems() => Items;

            public override void SetItems(List<ImportContactRecord>? value) => Items = value;
        }
    }
}