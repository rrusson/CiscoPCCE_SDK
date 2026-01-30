using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("results")]
    public class AgentList : BaseApiWrappedList<Agent>
    {
        [XmlArray("agents")]
        [XmlArrayItem("agent")]
        public new List<Agent>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}