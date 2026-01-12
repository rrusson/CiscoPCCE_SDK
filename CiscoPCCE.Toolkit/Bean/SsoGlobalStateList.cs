using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("results")]
    public class SsoGlobalStateList : BaseApiList<SsoGlobalState>
    {
        [XmlArray("ssoStates")]
        [XmlArrayItem("ssoState")]
        public new List<SsoGlobalState>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}