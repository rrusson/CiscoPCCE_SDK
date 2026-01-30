using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("internetscripteditor")
    [XmlRoot("results")]
    public class InternetScriptEditorList : BaseApiList<InternetScriptEditor>
    {
        [XmlArray("##defaults")]
        [XmlArrayItem("##default")]
        public new List<InternetScriptEditor>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}