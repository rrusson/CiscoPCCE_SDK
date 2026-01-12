using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("agenttargetingrule")
[XmlRoot("results")]
public class AgentTargetingRuleRangeList : BaseApiList<AgentTargetingRuleRange>
{
    [XmlArray("ranges")]
    [XmlArrayItem("range")]
    public new List<AgentTargetingRuleRange>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
