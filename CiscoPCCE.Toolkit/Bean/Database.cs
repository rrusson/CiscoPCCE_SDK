using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("database")
    [XmlRoot("database")]
    public class Database : BaseApiBean
    {
        public int? DataFileSizeMB { get; set; }

        public DbType DatabaseType { get; set; }

        public string? Drive { get; set; }

        public int? LogFileSizeMB { get; set; }

        public new string? RefURL { get; set; }

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