using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("results")]
    public class AgentList : BaseApiList<Agent>
    {
        [XmlArray("agents")]
        [XmlArrayItem("agent")]
        public new List<Agent>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

    [XmlElement("pageInfo")]
    public required PageInfo PageInfo { get; set; }

    [XmlElement("permissionInfo")]
    public required PermissionInfo PermissionInfo { get; set; }
    }
}