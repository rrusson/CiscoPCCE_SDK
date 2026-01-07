using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("activation")]
    public class ReportingActivation : BaseApiBean
    {
        public int? MessageBusNumber { get; set; }

        public int? Port { get; set; }

        public int? SubsystemNumber { get; set; }
    }
}