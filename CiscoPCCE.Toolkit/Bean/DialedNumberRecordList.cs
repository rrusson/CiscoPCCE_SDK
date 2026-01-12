using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("dialednumber")
[XmlRoot("results")]
public class DialedNumberRecordList : BaseApiList<DialedNumberRecord>
{
    [XmlArray("dialedNumberRecords")]
    [XmlArrayItem("dialedNumberRecord")]
    public new List<DialedNumberRecord>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
