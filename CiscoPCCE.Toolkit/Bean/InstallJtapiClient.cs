using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("installJtapiClients")]
            [XmlArrayItem("installJtapiClient")]
            public new List<InstallJtapiClient>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<InstallJtapiClient>? GetItems() => Items;

            public override void SetItems(List<InstallJtapiClient>? value) => Items = value;
        }
    }
}