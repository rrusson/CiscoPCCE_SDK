using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/eccpayload")
    [XmlRoot("eccpayload")]
    public class ECCPayload : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlArray("variables")]
        [XmlArrayItem("variable")]
        public List<ReferenceBean>? Variables { get; set; }

        // Path("/eccpayload")
        [XmlRoot("results")]
        public class ECCPayloadList : BaseApiListBean<ECCPayload>
        {
            public override List<ECCPayload>? GetItems() => Items;

            public override void SetItems(List<ECCPayload>? value) => Items = value;
        }
    }
}