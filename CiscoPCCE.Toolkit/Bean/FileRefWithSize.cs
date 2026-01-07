using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class FileRefWithSize : BaseApiBean {
    
  public string? RefURL { get; set; }

  public long? Size { get; set; }

}

}