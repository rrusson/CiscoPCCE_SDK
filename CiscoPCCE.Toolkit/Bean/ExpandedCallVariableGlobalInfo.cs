using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("expandedcallvariable")
    [XmlRoot("globalInfo")]
    public class ExpandedCallVariableGlobalInfo : BaseApiBean
    {
        [XmlElement("totalVariableCtiSize")]
        public int? TotalVariableCtiSize { get; set; }

        [XmlElement("totalVariableSize")]
        public int? TotalVariableSize { get; set; }
        
    }
}