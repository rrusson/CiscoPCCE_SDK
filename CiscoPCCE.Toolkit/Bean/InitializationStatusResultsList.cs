using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("initialize")
    [XmlRoot("results")]
    public class InitializationStatusResultsList : BaseApiList<InitializationStatusResults>
    {
        [XmlArray("resultss")]
        [XmlArrayItem("results")]
        public new List<InitializationStatusResults>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}