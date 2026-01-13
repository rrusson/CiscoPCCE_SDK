using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharequeue")
    [XmlRoot("results")]
    public class TargetQueueList : BaseApiList<TargetQueue>
    {
        [XmlArray("targetQueues")]
        [XmlArrayItem("targetQueue")]
        public new List<TargetQueue>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}