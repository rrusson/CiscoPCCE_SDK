using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class AtomLink : BaseApiBean {
      
  public string? Href { get; set; }

  public string? Rel { get; set; }

  public string? Type { get; set; }

}

}