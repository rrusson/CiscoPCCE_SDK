using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("installjtapiclient")
    [XmlRoot("results")]
    public class InstallJtapiClientList : BaseApiList<InstallJtapiClient>
    {
        [XmlArray("installJtapiClients")]
        [XmlArrayItem("installJtapiClient")]
        public new List<InstallJtapiClient>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}