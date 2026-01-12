using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("results")]
    public class IdsStatusList : BaseApiList<IdsStatus>
    {
        [XmlArray("idsStatuss")]
        [XmlArrayItem("idsStatus")]
        public new List<IdsStatus>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}