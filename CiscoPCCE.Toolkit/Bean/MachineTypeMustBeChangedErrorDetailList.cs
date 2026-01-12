using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class MachineTypeMustBeChangedErrorDetailList : BaseApiList<MachineTypeMustBeChangedErrorDetail>
    {
        [XmlArray("errorDetails")]
        [XmlArrayItem("errorDetail")]
        public new List<MachineTypeMustBeChangedErrorDetail>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}