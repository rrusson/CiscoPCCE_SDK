using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("internetscripteditor")
    [XmlRoot("##default")]
    public class InternetScriptEditor : BaseApiBean
    {
        [XmlElement("downloadLink")]
        public string? DownloadLink { get; set; }

        [XmlElement("enabled")]
        public bool? Enabled { get; set; }

        // Path("internetscripteditor")
        [XmlRoot("results")]
        public class InternetScriptEditorList : BaseApiListBean<InternetScriptEditor>
        {
            [XmlArray("##defaults")]
            [XmlArrayItem("##default")]
            public new List<InternetScriptEditor>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<InternetScriptEditor>? GetItems() => Items;

            public override void SetItems(List<InternetScriptEditor>? value) => Items = value;
        }
    }
}