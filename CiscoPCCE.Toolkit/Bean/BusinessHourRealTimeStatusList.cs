using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("businesshour")
[XmlRoot("results")]
public class BusinessHourRealTimeStatusList : BaseApiList<BusinessHourRealTimeStatus>
{
    [XmlArray("realTimeStatuss")]
    [XmlArrayItem("realTimeStatus")]
    public new List<BusinessHourRealTimeStatus>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
