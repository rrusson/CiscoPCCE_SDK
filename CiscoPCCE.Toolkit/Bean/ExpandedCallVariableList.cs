using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("expandedcallvariable")
    [XmlRoot("results")]
    public class ExpandedCallVariableList : BaseApiBean
    {
        [XmlElement("globalInfo")]
        public required ExpandedCallVariableGlobalInfo GlobalInfo { get; set; }

        [XmlArray("expandedCallVariables")]
        [XmlArrayItem("expandedCallVariable")]
        public List<ExpandedCallVariable>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
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