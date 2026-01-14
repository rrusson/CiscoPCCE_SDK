using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("expandedcallvariable")
    [XmlRoot("results")]
    public class ExpandedCallVariableGlobalInfoList : BaseApiList<ExpandedCallVariableGlobalInfo>
    {
        [XmlArray("globalInfos")]
        [XmlArrayItem("globalInfo")]
        public new List<ExpandedCallVariableGlobalInfo>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}