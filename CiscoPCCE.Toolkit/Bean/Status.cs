using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class Status : BaseApiBean {
  private ApiError apiError;
  private State state;

  public ApiError ApiError
  {
      get => apiError;
      set => apiError = value;
  }


  public void setApiError(ApiError apiError) {
     this.apiError = apiError;
  }

  public State State
  {
      get => state;
      set => state = value;
  }


  public void setState(State state) {
     this.state = state;
  }


}

}