using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharequeue")
    [XmlRoot("results")]
    public class TargetInstanceRefList : BaseApiList<TargetInstanceRef>
    {
        [XmlArray("targetInstances")]
        [XmlArrayItem("targetInstance")]
        public new List<TargetInstanceRef>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}