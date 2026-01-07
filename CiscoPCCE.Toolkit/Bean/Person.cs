using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("person")]
    public class Person : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public bool? DigitalChannel { get; set; }

        public bool? EcePerson { get; set; }

        public string? EmailAddress { get; set; }

        public string? FirstName { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? LastName { get; set; }

        public bool? LoginEnabled { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Password { get; set; }

        public new string? RefURL { get; set; }

        public string? ScreenName { get; set; }

        public bool? SsoEnabled { get; set; }

        public string? UserName { get; set; }

        // Path("agent")
        [XmlRoot("results")]
        public class PersonList : BaseApiListBean<Person>
        {
            public override List<Person>? GetItems() => Items;

            public override void SetItems(List<Person>? value) => Items = value;
        }
    }
}