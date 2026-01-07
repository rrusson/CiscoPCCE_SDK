using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationgateway")
    [XmlRoot("applicationGateway")]
    public class ApplicationGateway : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        [XmlElement("connections")]
        [XmlElement("connection")]
        public List<ApplicationGatewayConnection>? Connections { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public ApplicationGatewayEncryptionEnum Encryption { get; set; }

        public ApplicationGatewayFaultTolerance FaultTolerance { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public ApplicationGatewayPreferredSide PreferredSide { get; set; }

        public new string? RefURL { get; set; }

        // Path("applicationgateway")
        [XmlRoot("results")]
        public class ApplicationGatewayList : BaseApiListBean<ApplicationGateway>
        {
            public override List<ApplicationGateway>? GetItems() => Items;

            public override void SetItems(List<ApplicationGateway>? value) => Items = value;
        }
    }
}