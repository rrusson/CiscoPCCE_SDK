using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("networkvru")
    [XmlRoot("results")]
    public class NetworkVruList : BaseApiWrappedList<NetworkVru>
    {
        [XmlArray("networkVrus")]
        [XmlArrayItem("networkVru")]
        public new List<NetworkVru>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}