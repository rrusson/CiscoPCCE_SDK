using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("installjtapiclient")
    [XmlRoot("installJtapiClient")]
    public class InstallJtapiClient : BaseApiBean
    {
        [XmlElement("callManagerPublisherAddress")]
        public string? CallManagerPublisherAddress { get; set; }

        [XmlElement("callManagerPublisherVersion")]
        public string? CallManagerPublisherVersion { get; set; }

        // Path("installjtapiclient")
        [XmlRoot("results")]
        public class InstallJtapiClientList : BaseApiListBean<InstallJtapiClient>
        {
            public override List<InstallJtapiClient>? GetItems() => Items;

            public override void SetItems(List<InstallJtapiClient>? value) => Items = value;
        }
    }
}