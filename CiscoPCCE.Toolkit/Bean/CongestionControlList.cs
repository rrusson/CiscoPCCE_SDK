using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("congestioncontrol")
[XmlRoot("results")]
public class CongestionControlList : BaseApiList<CongestionControl>
{
    [XmlArray("congestionControls")]
    [XmlArrayItem("congestionControl")]
    public new List<CongestionControl>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
