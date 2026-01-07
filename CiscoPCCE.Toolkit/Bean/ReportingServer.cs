using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("reportingServer")]
public class ReportingServer : BaseApiBean {
  private string? ip;
  private int? messageBusNumber;

  public string? Ip
  {
      get => ip;
      set => ip = value;
  }


  public void setIp(String ip) {
     this.ip = ip;
  }

  public int? MessageBusNumber
  {
      get => messageBusNumber;
      set => messageBusNumber = value;
  }


  public void setMessageBusNumber(int? messageBusNumber) {
     this.messageBusNumber = messageBusNumber;
  }


}

}