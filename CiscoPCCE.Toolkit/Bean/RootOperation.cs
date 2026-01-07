using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("operation")]
    public class RootOperation : BaseApiBean
    {
        public required ChangeSet ChangeSet { get; set; }

        public OperationType OperationType { get; set; }

        [XmlElement("refURLs")]
        [XmlElement("refURL")]
        public List<string?>? RefUrls { get; set; }

        // Path("operation")
        [XmlRoot("results")]
        public class RootOperationList : BaseApiListBean<RootOperation>
        {
            public override List<RootOperation>? GetItems() => Items;

            public override void SetItems(List<RootOperation>? value) => Items = value;
        }
    }
}