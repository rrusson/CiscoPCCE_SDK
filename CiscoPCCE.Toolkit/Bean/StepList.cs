using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("precisionqueue")
[XmlRoot("results")]
public class StepList : BaseApiList<Step>
{
    [XmlArray("steps")]
    [XmlArrayItem("step")]
    public new List<Step>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
