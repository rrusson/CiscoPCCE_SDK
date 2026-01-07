using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("logcollection")
    [XmlRoot("logCollection")]
    public class LogCollection : BaseApiBean
    {
        [XmlElement("components")]
        [XmlElement("component")]
        public required Set Components { get; set; }

        public string? Description { get; set; }

        public long? EndDateTime { get; set; }

        public new string? RefURL { get; set; }

        [XmlElement("##default")]
        public required FileRefWithSize ResultsFile { get; set; }

        public long? StartDateTime { get; set; }

        public required Status Status { get; set; }

        // Path("logcollection")
        [XmlRoot("results")]
        public class LogCollectionList : BaseApiListBean<LogCollection>
        {
            public override List<LogCollection>? GetItems() => Items;

            public override void SetItems(List<LogCollection>? value) => Items = value;
        }
    }
}