using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class LoginSession : BaseApiBean {
  private int? sessionInactivityTimeout;

  public int? SessionInactivityTimeout
  {
      get => sessionInactivityTimeout;
      set => sessionInactivityTimeout = value;
  }


  public void setSessionInactivityTimeout(int? sessionInactivityTimeout) {
     this.sessionInactivityTimeout = sessionInactivityTimeout;
  }


}

}