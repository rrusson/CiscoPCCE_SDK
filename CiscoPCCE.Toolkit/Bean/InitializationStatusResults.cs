using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("initialize")
    [XmlRoot("results")]
    public class InitializationStatusResults : BaseApiBean
    {
        [XmlElement("state")]
        public StateEnum State { get; set; }

        [XmlArray("initializationStatuses")]
        [XmlArrayItem("initializationStatus")]
        public List<InitializationStatus>? StatusList { get; set; }

        // Path("initialize")
        [XmlRoot("results")]
        public class InitializationStatusResultsList : BaseApiListBean<InitializationStatusResults>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<InitializationStatusResults>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<InitializationStatusResults>? GetItems() => Items;

            public override void SetItems(List<InitializationStatusResults>? value) => Items = value;
        }
    }
}