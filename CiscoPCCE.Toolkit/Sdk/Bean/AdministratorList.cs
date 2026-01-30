using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("administrator")
    [XmlRoot("results")]
    public class AdministratorList : BaseApiWrappedList<Administrator>
    {
        [XmlArray("administrators")]
        [XmlArrayItem("administrator")]
        public new List<Administrator>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}