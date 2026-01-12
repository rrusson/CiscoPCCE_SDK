using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("results")]
    public class RootOperationList : BaseApiList<RootOperation>
    {
        [XmlArray("operations")]
        [XmlArrayItem("operation")]
        public new List<RootOperation>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}