using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("mediaroutingdomain")
    [XmlRoot("results")]
    public class MediaRoutingDomainList : BaseApiWrappedList<MediaRoutingDomain>
    {
        [XmlArray("mediaRoutingDomains")]
        [XmlArrayItem("mediaRoutingDomain")]
        public new List<MediaRoutingDomain>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}