using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("results")]
    public class RoutingTypeBeanList : BaseApiWrappedList<RoutingTypeBean>
    {
        [XmlArray("routingTypes")]
        [XmlArrayItem("routingType")]
        public new List<RoutingTypeBean>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}