using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/eccpayload")
    [XmlRoot("eccpayload")]
    public class ECCPayload : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        [XmlElement("variables")]
        [XmlElement("variable")]
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