using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("operation")]
    public class RootOperation : BaseApiBean
    {
        [XmlElement("changeSet")]
        public required ChangeSet ChangeSet { get; set; }

        [XmlElement("operationType")]
        public OperationType OperationType { get; set; }

        [XmlArray("refURLs")]
        [XmlArrayItem("refURL")]
        public List<string?>? RefUrls { get; set; }

        // Path("operation")
        [XmlRoot("results")]
        public class RootOperationList : BaseApiListBean<RootOperation>
        {
            [XmlArray("operations")]
            [XmlArrayItem("operation")]
            public new List<RootOperation>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<RootOperation>? GetItems() => Items;

            public override void SetItems(List<RootOperation>? value) => Items = value;
        }
    }
}