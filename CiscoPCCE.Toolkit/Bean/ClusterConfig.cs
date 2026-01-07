using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("ClusterConfig")]
public class ClusterConfig : BaseApiBean {
  
  public SecondaryNode SecondaryNode { get; set; }

}

}