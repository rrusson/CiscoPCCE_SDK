using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("status")
    [XmlRoot("results")]
    public class StatusResultsList : BaseApiList<StatusResults>
    {
        [XmlArray("resultss")]
        [XmlArrayItem("results")]
        public new List<StatusResults>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}