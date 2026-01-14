using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseProductInfoList : BaseApiWrappedList<SmartLicenseProductInfo>
    {
        [XmlArray("smartlicenseproductinfos")]
        [XmlArrayItem("smartlicenseproductinfo")]
        public new List<SmartLicenseProductInfo>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}