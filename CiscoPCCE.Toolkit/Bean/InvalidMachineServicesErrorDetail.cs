using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("errorDetail")]
    public class InvalidMachineServicesErrorDetail : BaseApiBean
    {
        [XmlElement("servicesFound")]
        [XmlElement("service")]
        public List<MachineService>? ServicesFound { get; set; }

        [XmlElement("servicesRequired")]
        [XmlElement("service")]
        public List<MachineService>? ServicesRequired { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class InvalidMachineServicesErrorDetailList : BaseApiListBean<InvalidMachineServicesErrorDetail>
        {
            public override List<InvalidMachineServicesErrorDetail>? GetItems() => Items;

            public override void SetItems(List<InvalidMachineServicesErrorDetail>? value) => Items = value;
        }
    }
}