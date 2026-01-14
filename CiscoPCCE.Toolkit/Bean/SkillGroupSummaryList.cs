using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("skillgroup")
    [XmlRoot("results")]
    public class SkillGroupSummaryList : BaseApiList<SkillGroupSummary>
    {
        [XmlArray("skillGroupSummarys")]
        [XmlArrayItem("skillGroupSummary")]
        public new List<SkillGroupSummary>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}