using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("generalsetting")
    [XmlRoot("generalSettings")]
    public class GeneralSetting : BaseApiBean
    {
        public bool? AgentEventDetailExtended { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required LoginSession LoginSession { get; set; }

        public new string? RefURL { get; set; }

        // Path("generalsetting")
        [XmlRoot("results")]
        public class GeneralSettingList : BaseApiListBean<GeneralSetting>
        {
            public override List<GeneralSetting>? GetItems() => Items;

            public override void SetItems(List<GeneralSetting>? value) => Items = value;
        }
    }
}