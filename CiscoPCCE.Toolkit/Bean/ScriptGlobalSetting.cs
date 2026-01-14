using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("script")]
    public class ScriptGlobalSetting : BaseApiBean
    {
        [XmlElement("retainScriptVersion")]
        public short? RetainScriptVersion { get; set; }
    }
}