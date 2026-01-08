using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("reporting")]
    public class ReportingGlobalSetting : BaseApiBean
    {
        [XmlElement("reportingInterval")]
        public int? ReportingInterval { get; set; }

        // Path("globalsetting")
        [XmlRoot("results")]
        public class ReportingGlobalSettingList : BaseApiListBean<ReportingGlobalSetting>
        {
            [XmlArray("reportings")]
            [XmlArrayItem("reporting")]
            public new List<ReportingGlobalSetting>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ReportingGlobalSetting>? GetItems() => Items;

            public override void SetItems(List<ReportingGlobalSetting>? value) => Items = value;
        }
    }
}