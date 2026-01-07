using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("internetscripteditor")
    [XmlRoot("##default")]
    public class InternetScriptEditor : BaseApiBean
    {
        public string? DownloadLink { get; set; }

        public bool? Enabled { get; set; }

        // Path("internetscripteditor")
        [XmlRoot("results")]
        public class InternetScriptEditorList : BaseApiListBean<InternetScriptEditor>
        {
            public override List<InternetScriptEditor>? GetItems() => Items;

            public override void SetItems(List<InternetScriptEditor>? value) => Items = value;
        }
    }
}