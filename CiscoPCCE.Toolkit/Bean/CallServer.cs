using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("server")]
public class CallServer : BaseApiBean {
  private string? address;
  private int? messageBusNumber;
  private int? port;
  private int? subsystemNumber;

  public string? Address
  {
      get => address;
      set => address = value;
  }


  public void setAddress(String address) {
     this.address = address;
  }

  public int? MessageBusNumber
  {
      get => messageBusNumber;
      set => messageBusNumber = value;
  }


  public void setMessageBusNumber(int? messageBusNumber) {
     this.messageBusNumber = messageBusNumber;
  }

  public int? Port
  {
      get => port;
      set => port = value;
  }


  public void setPort(int? port) {
     this.port = port;
  }

  public int? SubsystemNumber
  {
      get => subsystemNumber;
      set => subsystemNumber = value;
  }


  public void setSubsystemNumber(int? subsystemNumber) {
     this.subsystemNumber = subsystemNumber;
  }


}

}