using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("errorDetail")]
    public class MachineTypeMustBeChangedErrorDetail : BaseApiBean
    {
        public MachineType Type { get; set; }

        [XmlElement("validMachineTypes")]
        [XmlElement("type")]
        public List<MachineType>? ValidMachineTypes { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MachineTypeMustBeChangedErrorDetailList : BaseApiListBean<MachineTypeMustBeChangedErrorDetail>
        {
            public override List<MachineTypeMustBeChangedErrorDetail>? GetItems() => Items;

            public override void SetItems(List<MachineTypeMustBeChangedErrorDetail>? value) => Items = value;
        }
    }
}