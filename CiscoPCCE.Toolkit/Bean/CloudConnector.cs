using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("cloudconnectsettings")
    [XmlRoot("CloudConnectSettings")]
    public class CloudConnector : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? DeploymentID { get; set; }

        public string? DeploymentName { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? ProxyAddress { get; set; }

        public new string? RefURL { get; set; }

        public string? RegistrationStatus { get; set; }

        // Path("cloudconnectsettings")
        [XmlRoot("results")]
        public class CloudConnectorList : BaseApiListBean<CloudConnector>
        {
            public override List<CloudConnector>? GetItems() => Items;

            public override void SetItems(List<CloudConnector>? value) => Items = value;
        }
    }
}