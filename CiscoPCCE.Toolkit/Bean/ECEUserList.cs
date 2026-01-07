using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("users")]
    public class ECEUserList : BaseApiBean
    {
        public List<ECEUser>? Users { get; set; }
    }
}