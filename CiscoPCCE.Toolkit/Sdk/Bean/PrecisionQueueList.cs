using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("precisionqueue")
    [XmlRoot("results")]
    public class PrecisionQueueList : BaseApiWrappedList<PrecisionQueue>
    {
        [XmlArray("precisionQueues")]
        [XmlArrayItem("precisionQueue")]
        public new List<PrecisionQueue>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}