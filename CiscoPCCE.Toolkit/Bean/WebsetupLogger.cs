using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("logger")]
public class WebsetupLogger : BaseApiBean {
  private string? loggerSideAPrivateAddress;
  private string? loggerSideBPrivateAddress;
  private string? routerSideAPrivateAddress;
  private string? routerSideBPrivateAddress;
  private string? serviceAccountPassword;
  private string? serviceAccountUserName;
  private string? side;

  public string? LoggerSideAPrivateAddress
  {
      get => loggerSideAPrivateAddress;
      set => loggerSideAPrivateAddress = value;
  }


  public void setLoggerSideAPrivateAddress(String loggerSideAPrivateAddress) {
     this.loggerSideAPrivateAddress = loggerSideAPrivateAddress;
  }

  public string? LoggerSideBPrivateAddress
  {
      get => loggerSideBPrivateAddress;
      set => loggerSideBPrivateAddress = value;
  }


  public void setLoggerSideBPrivateAddress(String loggerSideBPrivateAddress) {
     this.loggerSideBPrivateAddress = loggerSideBPrivateAddress;
  }

  public string? RouterSideAPrivateAddress
  {
      get => routerSideAPrivateAddress;
      set => routerSideAPrivateAddress = value;
  }


  public void setRouterSideAPrivateAddress(String routerSideAPrivateAddress) {
     this.routerSideAPrivateAddress = routerSideAPrivateAddress;
  }

  public string? RouterSideBPrivateAddress
  {
      get => routerSideBPrivateAddress;
      set => routerSideBPrivateAddress = value;
  }


  public void setRouterSideBPrivateAddress(String routerSideBPrivateAddress) {
     this.routerSideBPrivateAddress = routerSideBPrivateAddress;
  }

  public string? ServiceAccountPassword
  {
      get => serviceAccountPassword;
      set => serviceAccountPassword = value;
  }


  public void setServiceAccountPassword(String serviceAccountPassword) {
     this.serviceAccountPassword = serviceAccountPassword;
  }

  public string? ServiceAccountUserName
  {
      get => serviceAccountUserName;
      set => serviceAccountUserName = value;
  }


  public void setServiceAccountUserName(String serviceAccountUserName) {
     this.serviceAccountUserName = serviceAccountUserName;
  }

  public string? Side
  {
      get => side;
      set => side = value;
  }


  public void setSide(String side) {
     this.side = side;
  }


}

}