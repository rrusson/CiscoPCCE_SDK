using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("configurationlimit")
    [XmlRoot("configurationLimit")]
    public class ConfigurationLimit : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("configLimitCurrentValue")]
        public int? ConfigLimitCurrentValue { get; set; }

        [XmlElement("configLimitDefaultValue")]
        public int? ConfigLimitDefaultValue { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
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