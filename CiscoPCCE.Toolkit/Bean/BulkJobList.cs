using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("bulkjob")
    [XmlRoot("results")]
    public class BulkJobList : BaseApiBean
    {
        [XmlElement("bulkJobs")]
        [XmlElement("bulkJob")]
        public List<BulkJob>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("bulkjob")
        [XmlRoot("results")]
        public class BulkJobListList : BaseApiListBean<BulkJobList>
        {
            public override List<BulkJobList>? GetItems() => Items;

            public override void SetItems(List<BulkJobList>? value) => Items = value;
        }
    }
}