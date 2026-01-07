using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("CloudConnectConfig")]
public class CloudConnectConfig : BaseApiBean {
  private string? password;
  private string? publisherAddress;
  private string? subscriberAddress;
  private string? userName;

  public string? Password
  {
      get => password;
      set => password = value;
  }


  public void setPassword(String password) {
     this.password = password;
  }

  public string? PublisherAddress
  {
      get => publisherAddress;
      set => publisherAddress = value;
  }


  public void setPublisherAddress(String publisherAddress) {
     this.publisherAddress = publisherAddress;
  }

  public string? SubscriberAddress
  {
      get => subscriberAddress;
      set => subscriberAddress = value;
  }


  public void setSubscriberAddress(String subscriberAddress) {
     this.subscriberAddress = subscriberAddress;
  }

  public string? UserName
  {
      get => userName;
      set => userName = value;
  }


  public void setUserName(String userName) {
     this.userName = userName;
  }


}

}