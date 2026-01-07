using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("cloudconnectsettings")
    [XmlRoot("dataSource")]
    public class DataSource : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        public required DataSourceDetails SideA { get; set; }

        public required DataSourceDetails SideB { get; set; }

        // Path("cloudconnectsettings")
        [XmlRoot("results")]
        public class DataSourceList : BaseApiListBean<DataSource>
        {
            public override List<DataSource>? GetItems() => Items;

            public override void SetItems(List<DataSource>? value) => Items = value;
        }
    }
}