using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("enterpriseroute")
    [XmlRoot("results")]
    public class EnterpriseRouteList : BaseApiWrappedList<EnterpriseRoute>
    {
        [XmlArray("enterpriseRoutes")]
        [XmlArrayItem("enterpriseRoute")]
        public new List<EnterpriseRoute>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}