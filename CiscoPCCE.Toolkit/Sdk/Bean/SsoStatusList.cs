using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("results")]
    public class SsoStatusList : BaseApiList<SsoStatus>
    {
        [XmlArray("ssoStatuss")]
        [XmlArrayItem("ssoStatus")]
        public new List<SsoStatus>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}