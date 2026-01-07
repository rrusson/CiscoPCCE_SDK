using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class Session : BaseApiBean {
      
  public int? OpenTimeout { get; set; }

  public int? RetryLimit { get; set; }

  public int? RetryTimeout { get; set; }

}

}