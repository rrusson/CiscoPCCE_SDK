using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("capacityRule")]
public class CapacityCheckResult : BaseApiBean {
        
  public long? Actual { get; set; }

  public Object CapacityCheckOperation { get; set; }

  public long? Max { get; set; }

  [XmlElement("name")]
  public string? Name { get; set; }

}

}