using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("ReasonCode")]
    public class ReasonCodeConfig : BaseApiBean
    {
        public bool? Active { get; set; }

        public string? Category { get; set; }

        public string? Code { get; set; }

        public string? ForAll { get; set; }

        public int Id { get; set; }

        public string? Label { get; set; }

        public long? Lastmodified { get; set; }

        public bool? SystemCode { get; set; }

        public string? Uri { get; set; }
    }
}