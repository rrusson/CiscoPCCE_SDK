using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class Machine : BaseApiBean {
        
  public string? Host { get; set; }

  public string? Name { get; set; }

  public string? RefURL { get; set; }

  public MachineType Type { get; set; }

}

}