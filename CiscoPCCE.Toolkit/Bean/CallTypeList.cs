using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("calltype")
    [XmlRoot("results")]
    public class CallTypeList : BaseApiWrappedList<CallType>
    {
        [XmlArray("callTypes")]
        [XmlArrayItem("callType")]
        public new List<CallType>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}