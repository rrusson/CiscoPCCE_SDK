using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class ApiError : BaseApiBean {
        
  public string? ErrorData { get; set; }

  public ApiErrorDetail ErrorDetail { get; set; }

  public string? ErrorMessage { get; set; }

  public string? ErrorType { get; set; }

}

}