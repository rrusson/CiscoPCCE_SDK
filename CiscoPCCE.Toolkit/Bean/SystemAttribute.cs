using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("systemattribute")
    [XmlRoot("systemAttribute")]
    public class SystemAttribute : BaseApiBean
    {
        private Object? value;

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public Object Value
        {
            get => value;
            set => _ = value;
        }

        public string? ValueString { get; set; }

        // Path("systemattribute")
        [XmlRoot("results")]
        public class SystemAttributeList : BaseApiListBean<SystemAttribute>
        {
            public override List<SystemAttribute>? GetItems() => Items;

            public override void SetItems(List<SystemAttribute>? value) => Items = value;
        }
    }
}