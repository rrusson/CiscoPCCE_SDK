using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("expandedcallvariable")
    [XmlRoot("globalInfo")]
    public class ExpandedCallVariableGlobalInfo : BaseApiBean
    {
        public int? TotalVariableCtiSize { get; set; }

        public int? TotalVariableSize { get; set; }

        // Path("expandedcallvariable")
        [XmlRoot("results")]
        public class ExpandedCallVariableGlobalInfoList : BaseApiListBean<ExpandedCallVariableGlobalInfo>
        {
            public override List<ExpandedCallVariableGlobalInfo>? GetItems() => Items;

            public override void SetItems(List<ExpandedCallVariableGlobalInfo>? value) => Items = value;
        }
    }
}