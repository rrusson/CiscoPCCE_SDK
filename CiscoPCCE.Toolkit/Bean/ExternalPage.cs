using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("externalpage")
    [XmlRoot("externalpage")]
    public class ExternalPage : BaseApiBean
    {
        public string? BaseData { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public required ReferenceBean Card { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? DynamicData { get; set; }

        public int? FeatureId { get; set; }

        public bool? Gadget { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? IpAddress { get; set; }

        public required ReferenceBean Menu { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public int? TabPosition { get; set; }

        public string? Url { get; set; }

        // Path("externalpage")
        [XmlRoot("results")]
        public class ExternalPageList : BaseApiListBean<ExternalPage>
        {
            public override List<ExternalPage>? GetItems() => Items;

            public override void SetItems(List<ExternalPage>? value) => Items = value;
        }
    }
}