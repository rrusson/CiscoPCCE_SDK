namespace CiscoPCCE.Toolkit.Bean
{
    public class AttributeValueWithAttribute : BaseApiBean
    {
        public required ReferenceBean Attribute { get; set; }

        public string? AttributeValue { get; set; }

        public string? Description { get; set; }
    }
}