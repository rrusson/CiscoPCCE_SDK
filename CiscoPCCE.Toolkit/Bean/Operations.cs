using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("operations")]
    public class Operations : BaseApiBean
    {
        [XmlElement("operation")]
        public List<Operation>? OperationList { get; set; }

        // Path("operation")
        [XmlRoot("results")]
        public class OperationsList : BaseApiListBean<Operations>
        {
            [XmlArray("operationss")]
            [XmlArrayItem("operations")]
            public new List<Operations>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<Operations>? GetItems() => Items;

            public override void SetItems(List<Operations>? value) => Items = value;
        }
    }
}