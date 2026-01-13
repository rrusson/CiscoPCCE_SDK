using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("results")]
    public class OperationsList : BaseApiList<Operations>
    {
        [XmlArray("operationss")]
        [XmlArrayItem("operations")]
        public new List<Operations>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}