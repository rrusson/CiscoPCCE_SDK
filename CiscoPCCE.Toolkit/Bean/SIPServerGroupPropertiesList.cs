using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroupproperties")
    [XmlRoot("results")]
    public class SIPServerGroupPropertiesList : BaseApiList<SIPServerGroupProperties>
    {
        [XmlArray("sipServerGroupPropertiess")]
        [XmlArrayItem("sipServerGroupProperties")]
        public new List<SIPServerGroupProperties>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}