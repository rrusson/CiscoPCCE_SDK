using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshourstatusreason")
    [XmlRoot("businessHourStatusReasons")]
    public class BusinessHourStatusReasons : BaseApiBean
    {
        public List<BusinessHourStatusReason>? BusinessHourStatusReason { get; set; }

        // Path("businesshourstatusreason")
        [XmlRoot("results")]
        public class BusinessHourStatusReasonsList : BaseApiListBean<BusinessHourStatusReasons>
        {
            [XmlArray("businessHourStatusReasonss")]
            [XmlArrayItem("businessHourStatusReasons")]
            public new List<BusinessHourStatusReasons>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<BusinessHourStatusReasons>? GetItems() => Items;

            public override void SetItems(List<BusinessHourStatusReasons>? value) => Items = value;
        }
    }
}