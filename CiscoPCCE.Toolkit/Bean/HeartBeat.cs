using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class HeartBeat : BaseApiBean {
  private int? interval;
  private int? requestTimeout;
  private int? retryLimit;
  private int? retryTimeout;

  public int? Interval
  {
      get => interval;
      set => interval = value;
  }


  public void setInterval(int? interval) {
     this.interval = interval;
  }

  public int? RequestTimeout
  {
      get => requestTimeout;
      set => requestTimeout = value;
  }


  public void setRequestTimeout(int? requestTimeout) {
     this.requestTimeout = requestTimeout;
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