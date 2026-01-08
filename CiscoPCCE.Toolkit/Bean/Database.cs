using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("database")
    [XmlRoot("database")]
    public class Database : BaseApiBean
    {
        [XmlElement("dataFileSizeMB")]
        public int? DataFileSizeMB { get; set; }

        [XmlElement("databaseType")]
        public DbType DatabaseType { get; set; }

        [XmlElement("drive")]
        public string? Drive { get; set; }

        [XmlElement("logFileSizeMB")]
        public int? LogFileSizeMB { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("side")]
        public Side Side { get; set; }

        // Path("database")
        [XmlRoot("results")]
        public class DatabaseList : BaseApiListBean<Database>
        {
            public override List<Database>? GetItems() => Items;

            public override void SetItems(List<Database>? value) => Items = value;
        }
    }
}