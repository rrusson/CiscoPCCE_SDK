using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("globalsetting")
[XmlRoot("results")]
public class LogicalInterfaceControllerList : BaseApiList<LogicalInterfaceController>
{
    [XmlArray("pgs")]
    [XmlArrayItem("pg")]
    public new List<LogicalInterfaceController>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
