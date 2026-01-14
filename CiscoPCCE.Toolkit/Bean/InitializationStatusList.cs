using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("initialize")
    [XmlRoot("results")]
    public class InitializationStatusList : BaseApiList<InitializationStatus>
    {
        [XmlArray("initializationStatuss")]
        [XmlArrayItem("initializationStatus")]
        public new List<InitializationStatus>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}