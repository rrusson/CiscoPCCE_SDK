using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("importContact")]
    public class ImportContactRecord : BaseApiBean
    {
        public string? AccountNumber { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public int CallResultOverall { get; set; }

        [XmlElement("callStatus")]
        public CallStatusEnum CallStatusEnum { get; set; }

        public int CallsMade { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? FirstName { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public DateTime? ImportDate { get; set; }

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