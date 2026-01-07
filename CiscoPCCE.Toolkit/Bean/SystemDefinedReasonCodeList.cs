using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("reasoncode")
    [XmlRoot("systemDefinedReasonCodes")]
    public class SystemDefinedReasonCodeList : BaseApiBean
    {
        public List<ReasonCode>? ReasonCode { get; set; }

        // Path("reasoncode")
        [XmlRoot("results")]
        public class SystemDefinedReasonCodeListList : BaseApiListBean<SystemDefinedReasonCodeList>
        {
            public override List<SystemDefinedReasonCodeList>? GetItems() => Items;

            public override void SetItems(List<SystemDefinedReasonCodeList>? value) => Items = value;
        }
    }
}