using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("generalsetting")
    [XmlRoot("generalSettings")]
    public class GeneralSetting : BaseApiBean
    {
        [XmlElement("agentEventDetailExtended")]
        public bool? AgentEventDetailExtended { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("loginSession")]
        public required LoginSession LoginSession { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("generalsetting")
        [XmlRoot("results")]
        public class GeneralSettingList : BaseApiListBean<GeneralSetting>
        {
            [XmlArray("generalSettingss")]
            [XmlArrayItem("generalSettings")]
            public new List<GeneralSetting>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<GeneralSetting>? GetItems() => Items;

            public override void SetItems(List<GeneralSetting>? value) => Items = value;
        }
    }
}