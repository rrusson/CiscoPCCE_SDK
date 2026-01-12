using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("operation")
[XmlRoot("results")]
public class OperationsResultList : BaseApiList<OperationsResult>
{
    [XmlArray("operationsResults")]
    [XmlArrayItem("operationsResult")]
    public new List<OperationsResult>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
