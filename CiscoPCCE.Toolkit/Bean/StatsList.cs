using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("stats")
    [XmlRoot("results")]
    public class StatsList : BaseApiList<Stats>
    {
        [XmlArray("statss")]
        [XmlArrayItem("stats")]
        public new List<Stats>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}