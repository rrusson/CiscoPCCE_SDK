using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("operationsResult")]
    public class OperationsResult : BaseApiBean
    {
        public required ApiErrors ApiErrors { get; set; }

        public required ChangeSet CreatedObjects { get; set; }

        public StatusType Status { get; set; }

        // Path("operation")
        [XmlRoot("results")]
        public class OperationsResultList : BaseApiListBean<OperationsResult>
        {
            public override List<OperationsResult>? GetItems() => Items;

            public override void SetItems(List<OperationsResult>? value) => Items = value;
        }
    }
}