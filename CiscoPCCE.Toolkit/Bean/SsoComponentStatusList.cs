using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("results")]
    public class SsoComponentStatusList : BaseApiList<SsoComponentStatus>
    {
        [XmlArray("ssoComponentStatuss")]
        [XmlArrayItem("ssoComponentStatus")]
        public new List<SsoComponentStatus>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}