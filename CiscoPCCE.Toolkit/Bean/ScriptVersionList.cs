using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("masterscript")
    [XmlRoot("results")]
    public class ScriptVersionList : BaseApiList<ScriptVersion>
    {
        [XmlArray("scriptVersions")]
        [XmlArrayItem("scriptVersion")]
        public new List<ScriptVersion>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}