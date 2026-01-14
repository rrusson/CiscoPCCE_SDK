using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("systemDefinedReasonCodes")]
    public class SystemDefinedReasonCodeList : BaseApiBean
    {
        public List<ReasonCode>? ReasonCode { get; set; }
    }
}