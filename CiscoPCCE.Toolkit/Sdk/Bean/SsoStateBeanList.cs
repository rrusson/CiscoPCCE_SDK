using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("results")]
    public class SsoStateBeanList : BaseApiList<SsoStateBean>
    {
        [XmlArray("SsoStates")]
        [XmlArrayItem("SsoState")]
        public new List<SsoStateBean>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}