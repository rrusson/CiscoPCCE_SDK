using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("card")]
    public class Card : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? Color { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Header { get; set; }

        public string? Icon { get; set; }

        public string? IdFromRefUrl { get; set; }

        public List<Menu>? Menus { get; set; }

        public new string? RefURL { get; set; }

        public bool? SystemDefined { get; set; }

        public string? UniqueId { get; set; }
    }
}