using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("expandedcallvariable")
    [XmlRoot("results")]
    public class ExpandedCallVariableList : BaseApiWrappedList<ExpandedCallVariable>
    {
        [XmlArray("expandedCallVariables")]
        [XmlArrayItem("expandedCallVariable")]
        public new List<ExpandedCallVariable>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}