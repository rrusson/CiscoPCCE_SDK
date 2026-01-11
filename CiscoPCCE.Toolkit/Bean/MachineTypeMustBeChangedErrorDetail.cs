using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("errorDetail")]
    public class MachineTypeMustBeChangedErrorDetail : BaseApiBean
    {
        [XmlElement("type")]
        public MachineType Type { get; set; }

        [XmlArray("validMachineTypes")]
        [XmlArrayItem("type")]
        public List<MachineType>? ValidMachineTypes { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MachineTypeMustBeChangedErrorDetailList : BaseApiListBean<MachineTypeMustBeChangedErrorDetail>
        {
            [XmlArray("errorDetails")]
            [XmlArrayItem("errorDetail")]
            public new List<MachineTypeMustBeChangedErrorDetail>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<MachineTypeMustBeChangedErrorDetail>? GetItems() => Items;

            public override void SetItems(List<MachineTypeMustBeChangedErrorDetail>? value) => Items = value;
        }
    }
}