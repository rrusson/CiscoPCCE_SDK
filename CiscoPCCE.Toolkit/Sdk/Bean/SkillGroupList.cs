using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("skillgroup")
    [XmlRoot("results")]
    public class SkillGroupList : BaseApiWrappedList<SkillGroupBase>
    {
        [XmlArray("skillGroups")]
        [XmlArrayItem("skillGroup")]
        public new List<SkillGroupBase>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}