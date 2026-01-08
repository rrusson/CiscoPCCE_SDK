using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("operationsResult")]
    public class OperationsResult : BaseApiBean
    {
        [XmlElement("apiErrors")]
        public required ApiErrors ApiErrors { get; set; }

        [XmlElement("createdObjects")]
        public required ChangeSet CreatedObjects { get; set; }

        [XmlElement("status")]
        public StatusType Status { get; set; }

        // Path("operation")
        [XmlRoot("results")]
        public class OperationsResultList : BaseApiListBean<OperationsResult>
        {
            [XmlArray("operationsResults")]
            [XmlArrayItem("operationsResult")]
            public new List<OperationsResult>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<OperationsResult>? GetItems() => Items;

            public override void SetItems(List<OperationsResult>? value) => Items = value;
        }
    }
}