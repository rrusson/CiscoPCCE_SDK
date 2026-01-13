using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("bulkjob")
    [XmlRoot("results")]
    public class BulkJobList : BaseApiList<BulkJob>
    {
        [XmlArray("bulkJobs")]
        [XmlArrayItem("bulkJob")]
        public new List<BulkJob>? Items
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