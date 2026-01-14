using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharegroup")
    [XmlRoot("results")]
    public class ContactShareGroupSummaryList : BaseApiList<ContactShareGroupSummary>
    {
        [XmlArray("contactShareGroupSummarys")]
        [XmlArrayItem("contactShareGroupSummary")]
        public new List<ContactShareGroupSummary>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}