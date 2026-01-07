using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ApplicationGatewayConnection : BaseApiBean {
  private string? address;
  private HeartBeat heartBeat;
  private bool? inService;
  private string? initializationData;
  private int? maxErrors;
  private int? port;
  private Session session;
  private ApplicationGatewayPreferredSide side;
  private Timeout timeout;

  public string? Address
  {
      get => address;
      set => address = value;
  }


  public void setAddress(String address) {
     this.address = address;
  }

  public HeartBeat HeartBeat
  {
      get => heartBeat;
      set => heartBeat = value;
  }


  public void setHeartBeat(HeartBeat heartBeat) {
     this.heartBeat = heartBeat;
  }

  public bool? InService
  {
      get => inService;
      set => inService = value;
  }


  public void setInService(Boolean inService) {
     this.inService = inService;
  }

  public string? InitializationData
  {
      get => initializationData;
      set => initializationData = value;
  }


  public void setInitializationData(String initializationData) {
     this.initializationData = initializationData;
  }

  public int? MaxErrors
  {
      get => maxErrors;
      set => maxErrors = value;
  }


  public void setMaxErrors(int? maxErrors) {
     this.maxErrors = maxErrors;
  }

  public int? Port
  {
      get => port;
      set => port = value;
  }


  public void setPort(int? port) {
     this.port = port;
  }

  public Session Session
  {
      get => session;
      set => session = value;
  }


  public void setSession(Session session) {
     this.session = session;
  }

  public ApplicationGatewayPreferredSide Side
  {
      get => side;
      set => side = value;
  }


  public void setSide(ApplicationGatewayPreferredSide side) {
     this.side = side;
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