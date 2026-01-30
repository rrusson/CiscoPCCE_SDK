using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("attribute")
    [XmlRoot("results")]
    public class AttributeSummaryList : BaseApiList<AttributeSummary>
    {
        [XmlArray("attributeSummarys")]
        [XmlArrayItem("attributeSummary")]
        public new List<AttributeSummary>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}