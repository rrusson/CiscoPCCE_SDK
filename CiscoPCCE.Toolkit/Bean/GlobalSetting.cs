using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("globalSettings")]
    public class GlobalSetting : BaseApiBean
    {
        [XmlElement("agent")]
        public required AgentGlobalSetting Agent { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("callReporting")]
        public required CallGlobalSetting CallReporting { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlArray("datacenterSettings")]
        [XmlArrayItem("datacenterSetting")]
        public List<DataCenterSetting>? DataCenterSettingList { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("labels")]
        public required NetworkLabelGlobalSetting Labels { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("reporting")]
        public required ReportingGlobalSetting Reporting { get; set; }

        [XmlElement("script")]
        public required ScriptGlobalSetting Script { get; set; }
        
    }
}