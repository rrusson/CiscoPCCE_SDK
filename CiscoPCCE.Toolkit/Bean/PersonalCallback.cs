using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("personalcallback")
    [XmlRoot("personalCallback")]
    public class PersonalCallback : BaseApiBean
    {
        [XmlElement("delimiter")]
        public string? Delimiter { get; set; }

        [XmlElement("fileContent")]
        public string? FileContent { get; set; }

        [XmlElement("overwriteData")]
        public bool? OverwriteData { get; set; }

        // Path("personalcallback")
        [XmlRoot("results")]
        public class PersonalCallbackList : BaseApiListBean<PersonalCallback>
        {
            [XmlArray("personalCallbacks")]
            [XmlArrayItem("personalCallback")]
            public new List<PersonalCallback>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<PersonalCallback>? GetItems() => Items;

            public override void SetItems(List<PersonalCallback>? value) => Items = value;
        }
    }
}