using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("results")]
    public class LabelList : BaseApiList<Label>
    {
        [XmlArray("labels")]
        [XmlArrayItem("label")]
        public new List<Label>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}