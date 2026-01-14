using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingpattern")
    [XmlRoot("results")]
    public class RoutingPatternList : BaseApiWrappedList<RoutingPattern>
    {
        [XmlArray("routingPatterns")]
        [XmlArrayItem("routingPattern")]
        public new List<RoutingPattern>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}