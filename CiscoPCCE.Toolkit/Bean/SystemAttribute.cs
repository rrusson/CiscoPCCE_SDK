using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("systemattribute")
    [XmlRoot("systemAttribute")]
    public class SystemAttribute : BaseApiBean
    {
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

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("value")]
        public Object? Value { get; set; }

        [XmlElement("valueString")]
        public string? ValueString { get; set; }

        // Path("systemattribute")
        [XmlRoot("results")]
        public class SystemAttributeList : BaseApiListBean<SystemAttribute>
        {
            [XmlArray("systemAttributes")]
            [XmlArrayItem("systemAttribute")]
            public new List<SystemAttribute>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SystemAttribute>? GetItems() => Items;

            public override void SetItems(List<SystemAttribute>? value) => Items = value;
        }
    }
}