using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class Status : BaseApiBean {
    
  public ApiError ApiError { get; set; }

  public State State { get; set; }

}

}