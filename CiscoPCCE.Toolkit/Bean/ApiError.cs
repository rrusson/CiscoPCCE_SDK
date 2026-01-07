using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ApiError : BaseApiBean {
  private string? errorData;
  private ApiErrorDetail errorDetail;
  private string? errorMessage;
  private string? errorType;

  public string? ErrorData
  {
      get => errorData;
      set => errorData = value;
  }


  public void setErrorData(String errorData) {
     this.errorData = errorData;
  }

  public ApiErrorDetail ErrorDetail
  {
      get => errorDetail;
      set => errorDetail = value;
  }


  public void setErrorDetail(ApiErrorDetail errorDetail) {
     this.errorDetail = errorDetail;
  }

  public string? ErrorMessage
  {
      get => errorMessage;
      set => errorMessage = value;
  }


  public void setErrorMessage(String errorMessage) {
     this.errorMessage = errorMessage;
  }

  public string? ErrorType
  {
      get => errorType;
      set => errorType = value;
  }


  public void setErrorType(String errorType) {
     this.errorType = errorType;
  }


}

}