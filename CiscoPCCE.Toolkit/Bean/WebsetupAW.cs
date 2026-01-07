using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("aw")]
public class WebsetupAW : BaseApiBean {
  private string? loggerSideAPublicAddress;
  private string? loggerSideBPublicAddress;
  private string? preferredSide;
  private string? primaryAdminAndDataServerName;
  private string? routerSideAPublicAddress;
  private string? routerSideBPublicAddress;
  private string? secondaryAdminAndDataServerName;
  private string? serviceAccountPassword;
  private string? serviceAccountUserName;

  public string? LoggerSideAPublicAddress
  {
      get => loggerSideAPublicAddress;
      set => loggerSideAPublicAddress = value;
  }


  public void setLoggerSideAPublicAddress(String loggerSideAPublicAddress) {
     this.loggerSideAPublicAddress = loggerSideAPublicAddress;
  }

  public string? LoggerSideBPublicAddress
  {
      get => loggerSideBPublicAddress;
      set => loggerSideBPublicAddress = value;
  }


  public void setLoggerSideBPublicAddress(String loggerSideBPublicAddress) {
     this.loggerSideBPublicAddress = loggerSideBPublicAddress;
  }

  public string? PreferredSide
  {
      get => preferredSide;
      set => preferredSide = value;
  }


  public void setPreferredSide(String preferredSide) {
     this.preferredSide = preferredSide;
  }

  public string? PrimaryAdminAndDataServerName
  {
      get => primaryAdminAndDataServerName;
      set => primaryAdminAndDataServerName = value;
  }


  public void setPrimaryAdminAndDataServerName(String primaryAdminAndDataServerName) {
     this.primaryAdminAndDataServerName = primaryAdminAndDataServerName;
  }

  public string? RouterSideAPublicAddress
  {
      get => routerSideAPublicAddress;
      set => routerSideAPublicAddress = value;
  }


  public void setRouterSideAPublicAddress(String routerSideAPublicAddress) {
     this.routerSideAPublicAddress = routerSideAPublicAddress;
  }

  public string? RouterSideBPublicAddress
  {
      get => routerSideBPublicAddress;
      set => routerSideBPublicAddress = value;
  }


  public void setRouterSideBPublicAddress(String routerSideBPublicAddress) {
     this.routerSideBPublicAddress = routerSideBPublicAddress;
  }

  public string? SecondaryAdminAndDataServerName
  {
      get => secondaryAdminAndDataServerName;
      set => secondaryAdminAndDataServerName = value;
  }


  public void setSecondaryAdminAndDataServerName(String secondaryAdminAndDataServerName) {
     this.secondaryAdminAndDataServerName = secondaryAdminAndDataServerName;
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


}

}