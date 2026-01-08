using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("bulkjob")
    [XmlRoot("results")]
    public class BulkJobList : BaseApiBean
    {
        [XmlArray("bulkJobs")]
        [XmlArrayItem("bulkJob")]
        public List<BulkJob>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("bulkjob")
        [XmlRoot("results")]
        public class BulkJobListList : BaseApiListBean<BulkJobList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<BulkJobList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<BulkJobList>? GetItems() => Items;

            public override void SetItems(List<BulkJobList>? value) => Items = value;
        }
    }
}