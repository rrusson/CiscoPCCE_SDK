using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("cloudconnectsettings")
    [XmlRoot("dataSource")]
    public class DataSource : BaseApiBean
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

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("sideA")]
        public required DataSourceDetails SideA { get; set; }

        [XmlElement("sideB")]
        public required DataSourceDetails SideB { get; set; }

        // Path("cloudconnectsettings")
        [XmlRoot("results")]
        public class DataSourceList : BaseApiListBean<DataSource>
        {
            [XmlArray("dataSources")]
            [XmlArrayItem("dataSource")]
            public new List<DataSource>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<DataSource>? GetItems() => Items;

            public override void SetItems(List<DataSource>? value) => Items = value;
        }
    }
}