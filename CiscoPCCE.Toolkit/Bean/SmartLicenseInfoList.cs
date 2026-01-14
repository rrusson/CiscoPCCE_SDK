using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseInfoList : BaseApiWrappedList<SmartLicenseInfo>
    {
        [XmlArray("smartlicenseinfos")]
        [XmlArrayItem("smartlicenseinfo")]
        public new List<SmartLicenseInfo>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}