using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("attribute")
    [XmlRoot("results")]
    public class AttributeList : BaseApiWrappedList<AttributeBase>
    {
        [XmlArray("attributes")]
        [XmlArrayItem("attribute")]
        public new List<AttributeBase>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}