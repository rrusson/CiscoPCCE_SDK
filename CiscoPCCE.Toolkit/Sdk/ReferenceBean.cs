using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Sdk
{
    /// <summary>
    /// Reference Bean for associating one bean type with another.
    /// </summary>
    public class ReferenceBean : BaseBean
    {
        public ReferenceBean()
        {
        }

        public ReferenceBean(string refURL)
        {
            RefURL = refURL;
        }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public string? RefURL { get; set; }
    }
}
