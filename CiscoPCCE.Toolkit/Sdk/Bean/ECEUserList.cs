using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("users")]
    public class ECEUserList : BaseApiBean
    {
        public List<ECEUser>? Users { get; set; }
    }
}