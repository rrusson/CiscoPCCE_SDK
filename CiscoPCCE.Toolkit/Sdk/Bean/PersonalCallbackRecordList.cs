using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("personalcallback")
    [XmlRoot("results")]
    public class PersonalCallbackRecordList : BaseApiWrappedList<PersonalCallbackRecord>
    {
        [XmlArray("personalCallbacks")]
        [XmlArrayItem("personalCallback")]
        public new List<PersonalCallbackRecord>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}