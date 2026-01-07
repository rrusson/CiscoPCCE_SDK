using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("locationproperties")
    [XmlRoot("CVP")]
    public class CVPLocationProperties : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required LocationProperties LocationProperties { get; set; }

        public new string? RefURL { get; set; }

        // Path("locationproperties")
        [XmlRoot("results")]
        public class CVPLocationPropertiesList : BaseApiListBean<CVPLocationProperties>
        {
            public override List<CVPLocationProperties>? GetItems() => Items;

            public override void SetItems(List<CVPLocationProperties>? value) => Items = value;
        }
    }
}