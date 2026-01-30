using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharequeue")
    [XmlRoot("results")]
    public class ContactShareQueueList : BaseApiWrappedList<ContactShareQueue>
    {
        [XmlArray("contactShareQueues")]
        [XmlArrayItem("contactShareQueue")]
        public new List<ContactShareQueue>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}