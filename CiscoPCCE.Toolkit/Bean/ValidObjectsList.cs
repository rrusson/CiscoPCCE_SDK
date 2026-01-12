using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("validobjects")
    [XmlRoot("results")]
    public class ValidObjectsList : BaseApiList<ValidObjects>
    {
        [XmlArray("validObjectss")]
        [XmlArrayItem("validObjects")]
        public new List<ValidObjects>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}