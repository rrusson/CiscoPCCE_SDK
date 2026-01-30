using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("dialednumber")
    [XmlRoot("results")]
    public class DialedNumberList : BaseApiWrappedList<DialedNumber>
    {
        [XmlArray("dialedNumbers")]
        [XmlArrayItem("dialedNumber")]
        public new List<DialedNumber>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}