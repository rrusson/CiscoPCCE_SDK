using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("cloudconnectsettings")
    [XmlRoot("results")]
    public class CloudConnectorList : BaseApiList<CloudConnector>
    {
        [XmlArray("CloudConnectSettingss")]
        [XmlArrayItem("CloudConnectSettings")]
        public new List<CloudConnector>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}