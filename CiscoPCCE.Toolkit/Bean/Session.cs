using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class Session : BaseApiBean {
  private int? openTimeout;
  private int? retryLimit;
  private int? retryTimeout;

  public int? OpenTimeout
  {
      get => openTimeout;
      set => openTimeout = value;
  }


  public void setOpenTimeout(int? openTimeout) {
     this.openTimeout = openTimeout;
  }

  public int? RetryLimit
  {
      get => retryLimit;
      set => retryLimit = value;
  }


  public void setRetryLimit(int? retryLimit) {
     this.retryLimit = retryLimit;
  }

  public int? RetryTimeout
  {
      get => retryTimeout;
      set => retryTimeout = value;
  }


  public void setRetryTimeout(int? retryTimeout) {
     this.retryTimeout = retryTimeout;
  }


}

}