using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("configurationlimit")
    [XmlRoot("configurationLimit")]
    public class ConfigurationLimit : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public int? ConfigLimitCurrentValue { get; set; }

        public int? ConfigLimitDefaultValue { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        // Path("configurationlimit")
        [XmlRoot("results")]
        public class ConfigurationLimitList : BaseApiListBean<ConfigurationLimit>
        {
            public override List<ConfigurationLimit>? GetItems() => Items;

            public override void SetItems(List<ConfigurationLimit>? value) => Items = value;
        }
    }
}