using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ConnectionParametersGlobal : BaseApiBean {
  private HeartBeat heartBeat;
  private int? maxErrors;
  private Session session;
  private Timeout timeout;

  public HeartBeat HeartBeat
  {
      get => heartBeat;
      set => heartBeat = value;
  }


  public void setHeartBeat(HeartBeat heartBeat) {
     this.heartBeat = heartBeat;
  }

  public int? MaxErrors
  {
      get => maxErrors;
      set => maxErrors = value;
  }


  public void setMaxErrors(int? maxErrors) {
     this.maxErrors = maxErrors;
  }

  public Session Session
  {
      get => session;
      set => session = value;
  }


  public void setSession(Session session) {
     this.session = session;
  }

  public Timeout Timeout
  {
      get => timeout;
      set => timeout = value;
  }


  public void setTimeout(Timeout timeout) {
     this.timeout = timeout;
  }


}

}