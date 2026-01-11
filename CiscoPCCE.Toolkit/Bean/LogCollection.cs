using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("logcollection")
    [XmlRoot("logCollection")]
    public class LogCollection : BaseApiBean
    {
        [XmlElement("components")]
        [XmlElement("component")]
        public required Set Components { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("endDateTime")]
        public long? EndDateTime { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("##default")]
        public required FileRefWithSize ResultsFile { get; set; }

        [XmlElement("startDateTime")]
        public long? StartDateTime { get; set; }

        [XmlElement("status")]
        public required Status Status { get; set; }

        // Path("logcollection")
        [XmlRoot("results")]
        public class LogCollectionList : BaseApiListBean<LogCollection>
        {
            [XmlArray("logCollections")]
            [XmlArrayItem("logCollection")]
            public new List<LogCollection>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<LogCollection>? GetItems() => Items;

            public override void SetItems(List<LogCollection>? value) => Items = value;
        }
    }
}