using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("businessHourStatusReasons")]
    public class BusinessHourStatusReasons : BaseApiBean
    {
        public List<BusinessHourStatusReason>? BusinessHourStatusReason { get; set; }
    }
}