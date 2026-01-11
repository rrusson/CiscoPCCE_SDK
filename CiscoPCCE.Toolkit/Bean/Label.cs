using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("label")]
    public class Label : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("networkTarget")]
        public required ReferenceBean NetworkTarget { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("globalsetting")
        [XmlRoot("results")]
        public class LabelList : BaseApiListBean<Label>
        {
            [XmlArray("labels")]
            [XmlArrayItem("label")]
            public new List<Label>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<Label>? GetItems() => Items;

            public override void SetItems(List<Label>? value) => Items = value;
        }
    }
}