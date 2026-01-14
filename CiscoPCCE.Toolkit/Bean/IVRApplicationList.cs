using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("transferablefiles")
    [XmlRoot("results")]
    public class IVRApplicationList : BaseApiWrappedList<IVRApplication>
    {
        [XmlArray("IVRApplications")]
        [XmlArrayItem("IVRApplication")]
        public new List<IVRApplication>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}