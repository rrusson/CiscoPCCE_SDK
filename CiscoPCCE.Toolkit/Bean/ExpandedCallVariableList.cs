using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("expandedcallvariable")
    [XmlRoot("results")]
    public class ExpandedCallVariableList : BaseApiBean
    {
        public required ExpandedCallVariableGlobalInfo GlobalInfo { get; set; }

        [XmlElement("expandedCallVariables")]
        [XmlElement("expandedCallVariable")]
        public List<ExpandedCallVariable>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("expandedcallvariable")
        [XmlRoot("results")]
        public class ExpandedCallVariableListList : BaseApiListBean<ExpandedCallVariableList>
        {
            public override List<ExpandedCallVariableList>? GetItems() => Items;

            public override void SetItems(List<ExpandedCallVariableList>? value) => Items = value;
        }
    }
}