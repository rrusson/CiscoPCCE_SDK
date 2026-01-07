using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("initialize")
    [XmlRoot("##default")]
    public class InitialSettings : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public required ReferenceBean CmSideA { get; set; }

        public required ReferenceBean CmSideB { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? HardwareLayoutType { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? MobileAgentCodec { get; set; }

        public new string? RefURL { get; set; }

        public string? ServiceAccountPassword { get; set; }

        public string? ServiceAccountUserName { get; set; }

        // Path("initialize")
        [XmlRoot("results")]
        public class InitialSettingsList : BaseApiListBean<InitialSettings>
        {
            public override List<InitialSettings>? GetItems() => Items;

            public override void SetItems(List<InitialSettings>? value) => Items = value;
        }
    }
}