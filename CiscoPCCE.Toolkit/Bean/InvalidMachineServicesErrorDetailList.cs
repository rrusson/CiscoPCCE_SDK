using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class InvalidMachineServicesErrorDetailList : BaseApiList<InvalidMachineServicesErrorDetail>
    {
        [XmlArray("errorDetails")]
        [XmlArrayItem("errorDetail")]
        public new List<InvalidMachineServicesErrorDetail>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}