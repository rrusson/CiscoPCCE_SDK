using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class ICMPostRouting : BaseApiBean {
      
  public string? DefaultScript { get; set; }

  public string? InitialScript { get; set; }

  public int Timeout { get; set; }

}

}