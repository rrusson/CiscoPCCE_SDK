using System.Xml.Serialization;

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