using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("errorDetail")]
    public class InvalidMachineServicesErrorDetail : BaseApiBean
    {
        [XmlArray("servicesFound")]
        [XmlArrayItem("service")]
        public List<MachineService>? ServicesFound { get; set; }

        [XmlArray("servicesRequired")]
        [XmlArrayItem("service")]
        public List<MachineService>? ServicesRequired { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class InvalidMachineServicesErrorDetailList : BaseApiListBean<InvalidMachineServicesErrorDetail>
        {
            [XmlArray("errorDetails")]
            [XmlArrayItem("errorDetail")]
            public new List<InvalidMachineServicesErrorDetail>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<InvalidMachineServicesErrorDetail>? GetItems() => Items;

            public override void SetItems(List<InvalidMachineServicesErrorDetail>? value) => Items = value;
        }
    }
}