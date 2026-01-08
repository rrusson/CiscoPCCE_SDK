using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("locationproperties")
    [XmlRoot("CVP")]
    public class CVPLocationProperties : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("locationProperties")]
        public required LocationProperties LocationProperties { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("locationproperties")
        [XmlRoot("results")]
        public class CVPLocationPropertiesList : BaseApiListBean<CVPLocationProperties>
        {
            [XmlArray("CVPs")]
            [XmlArrayItem("CVP")]
            public new List<CVPLocationProperties>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<CVPLocationProperties>? GetItems() => Items;

            public override void SetItems(List<CVPLocationProperties>? value) => Items = value;
        }
    }
}