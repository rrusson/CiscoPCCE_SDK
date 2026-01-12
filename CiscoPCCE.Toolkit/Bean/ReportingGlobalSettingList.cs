using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("globalsetting")
[XmlRoot("results")]
public class ReportingGlobalSettingList : BaseApiList<ReportingGlobalSetting>
{
    [XmlArray("reportings")]
    [XmlArrayItem("reporting")]
    public new List<ReportingGlobalSetting>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
