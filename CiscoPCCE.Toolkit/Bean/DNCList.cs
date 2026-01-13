using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    /// <summary>
    /// A collection of ImportRules
    /// </summary>
    /// <remarks>Duplicates <see cref="ImportRuleList"/></remarks>
    [XmlRoot("results")]
    public class DNCList : BaseApiList<ImportRule>
    {
        [XmlArray("dncs")]
        [XmlArrayItem("dnc")]
        public new List<ImportRule>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}