using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("precisionqueue")
    [XmlRoot("step")]
    public class Step : BaseApiBean
    {
        public int? AgentCount { get; set; }

        public string? ConsiderIf { get; set; }

        public string? Description { get; set; }

        public new string? RefURL { get; set; }

        [XmlElement("terms")]
        [XmlElement("term")]
        public List<Term>? Terms { get; set; }

        public int? WaitTime { get; set; }

        // Path("precisionqueue")
        [XmlRoot("results")]
        public class StepList : BaseApiListBean<Step>
        {
            public override List<Step>? GetItems() => Items;

            public override void SetItems(List<Step>? value) => Items = value;
        }
    }
}