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
            [XmlArray("systemDefinedReasonCodess")]
            [XmlArrayItem("systemDefinedReasonCodes")]
            public new List<SystemDefinedReasonCodeList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SystemDefinedReasonCodeList>? GetItems() => Items;

            public override void SetItems(List<SystemDefinedReasonCodeList>? value) => Items = value;
        }
    }
}