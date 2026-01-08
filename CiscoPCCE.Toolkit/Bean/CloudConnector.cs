using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("cloudconnectsettings")
    [XmlRoot("CloudConnectSettings")]
    public class CloudConnector : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("deploymentID")]
        public string? DeploymentID { get; set; }

        [XmlElement("deploymentName")]
        public string? DeploymentName { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("proxyAddress")]
        public string? ProxyAddress { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("registrationStatus")]
        public string? RegistrationStatus { get; set; }

        // Path("cloudconnectsettings")
        [XmlRoot("results")]
        public class CloudConnectorList : BaseApiListBean<CloudConnector>
        {
            [XmlArray("CloudConnectSettingss")]
            [XmlArrayItem("CloudConnectSettings")]
            public new List<CloudConnector>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<CloudConnector>? GetItems() => Items;

            public override void SetItems(List<CloudConnector>? value) => Items = value;
        }
    }
}