using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationpath")
    [XmlRoot("results")]
    public class ApplicationPathMemberList : BaseApiList<ApplicationPathMember>
    {
        [XmlArray("applicationPathMembers")]
        [XmlArrayItem("applicationPathMember")]
        public new List<ApplicationPathMember>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}