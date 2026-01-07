using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("globalSettings")]
    public class GlobalSetting : BaseApiBean
    {
        public required AgentGlobalSetting Agent { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public required CallGlobalSetting CallReporting { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        [XmlElement("datacenterSettings")]
        [XmlElement("datacenterSetting")]
        public List<DataCenterSetting>? DataCenterSettingList { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required NetworkLabelGlobalSetting Labels { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        public new string? RefURL { get; set; }

        public required ReportingGlobalSetting Reporting { get; set; }

        public required ScriptGlobalSetting Script { get; set; }

        // Path("globalsetting")
        [XmlRoot("results")]
        public class GlobalSettingList : BaseApiListBean<GlobalSetting>
        {
            public override List<GlobalSetting>? GetItems() => Items;

            public override void SetItems(List<GlobalSetting>? value) => Items = value;
        }
    }
}