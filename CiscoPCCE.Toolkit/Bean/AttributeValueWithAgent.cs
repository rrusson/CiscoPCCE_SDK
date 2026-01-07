namespace CiscoPCCE.Toolkit.Bean
{
    public class AttributeValueWithAgent : BaseApiBean
    {
        public required ReferenceBean Agent { get; set; }

        public string? AttributeValue { get; set; }

        public string? Description { get; set; }
    }
}