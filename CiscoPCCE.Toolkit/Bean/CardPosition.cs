using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class CardPosition : BaseApiBean {
    
  public int Position { get; set; }

  public string? RefURL { get; set; }

}

}