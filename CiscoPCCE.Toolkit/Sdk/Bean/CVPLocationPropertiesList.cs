using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("locationproperties")
    [XmlRoot("results")]
    public class CVPLocationPropertiesList : BaseApiList<CVPLocationProperties>
    {
        [XmlArray("CVPs")]
        [XmlArrayItem("CVP")]
        public new List<CVPLocationProperties>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}