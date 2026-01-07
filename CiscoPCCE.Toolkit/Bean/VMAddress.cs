using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class VMAddress : BaseApiBean {
      
  public string? IpAddress { get; set; }

  public string? Name { get; set; }

  public string? NetworkType { get; set; }

}

}