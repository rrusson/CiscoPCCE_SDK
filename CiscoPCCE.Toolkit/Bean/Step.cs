using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("precisionqueue")
    [XmlRoot("step")]
    public class Step : BaseApiBean
    {
        [XmlElement("agentCount")]
        public int? AgentCount { get; set; }

        [XmlElement("considerIf")]
        public string? ConsiderIf { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlArray("terms")]
        [XmlArrayItem("term")]
        public List<Term>? Terms { get; set; }

        [XmlElement("waitTime")]
        public int? WaitTime { get; set; }

        // Path("precisionqueue")
        [XmlRoot("results")]
        public class StepList : BaseApiListBean<Step>
        {
            [XmlArray("steps")]
            [XmlArrayItem("step")]
            public new List<Step>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<Step>? GetItems() => Items;

            public override void SetItems(List<Step>? value) => Items = value;
        }
    }
}