using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("results")]
    public class DatacenterRoutingTypeBeanList : BaseApiWrappedList<DatacenterRoutingTypeBean>
    {
        [XmlArray("datacenterRoutingTypes")]
        [XmlArrayItem("datacenterRoutingType")]
        public new List<DatacenterRoutingTypeBean>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}