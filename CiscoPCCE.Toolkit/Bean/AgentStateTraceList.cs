using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("agentstatetrace")
[XmlRoot("results")]
public class AgentStateTraceList : BaseApiList<AgentStateTrace>
{
    [XmlArray("agentstatetraces")]
    [XmlArrayItem("agentstatetrace")]
    public new List<AgentStateTrace>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
