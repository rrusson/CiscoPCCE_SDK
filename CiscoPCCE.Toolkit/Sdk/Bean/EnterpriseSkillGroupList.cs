using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("enterpriseroute")
    [XmlRoot("results")]
    public class EnterpriseSkillGroupList : BaseApiWrappedList<EnterpriseSkillGroup>
    {
        [XmlArray("enterpriseSkillGroups")]
        [XmlArrayItem("enterpriseSkillGroup")]
        public new List<EnterpriseSkillGroup>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}