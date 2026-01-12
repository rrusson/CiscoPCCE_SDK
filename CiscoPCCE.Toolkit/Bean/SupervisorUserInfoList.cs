using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("results")]
    public class SupervisorUserInfoList : BaseApiList<SupervisorUserInfo>
    {
        [XmlArray("supervisorUserInfos")]
        [XmlArrayItem("supervisorUserInfo")]
        public new List<SupervisorUserInfo>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}