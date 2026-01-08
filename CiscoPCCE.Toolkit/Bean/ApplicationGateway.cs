using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationgateway")
    [XmlRoot("applicationGateway")]
    public class ApplicationGateway : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlArray("connections")]
        [XmlArrayItem("connection")]
        public List<ApplicationGatewayConnection>? Connections { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("encryption")]
        public ApplicationGatewayEncryptionEnum Encryption { get; set; }

        [XmlElement("faultTolerance")]
        public ApplicationGatewayFaultTolerance FaultTolerance { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("preferredSide")]
        public ApplicationGatewayPreferredSide PreferredSide { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("applicationgateway")
        [XmlRoot("results")]
        public class ApplicationGatewayList : BaseApiListBean<ApplicationGateway>
        {
            [XmlArray("applicationGateways")]
            [XmlArrayItem("applicationGateway")]
            public new List<ApplicationGateway>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ApplicationGateway>? GetItems() => Items;

            public override void SetItems(List<ApplicationGateway>? value) => Items = value;
        }
    }
}