using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("cloudconnectsettings")
[XmlRoot("CloudConnectSettings")]
public class CloudConnector : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? deploymentID;
  private string? deploymentName;
  private int? id;
  private string? idFromRefUrl;
  private string? proxyAddress;
  private string? refURL;
  private string? registrationStatus;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? DeploymentID
  {
      get => deploymentID;
      set => deploymentID = value;
  }


  public void setDeploymentID(String deploymentID) {
     this.deploymentID = deploymentID;
  }

  public string? DeploymentName
  {
      get => deploymentName;
      set => deploymentName = value;
  }


  public void setDeploymentName(String deploymentName) {
     this.deploymentName = deploymentName;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? ProxyAddress
  {
      get => proxyAddress;
      set => proxyAddress = value;
  }


  public void setProxyAddress(String proxyAddress) {
     this.proxyAddress = proxyAddress;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? RegistrationStatus
  {
      get => registrationStatus;
      set => registrationStatus = value;
  }


  public void setRegistrationStatus(String registrationStatus) {
     this.registrationStatus = registrationStatus;
  }


  // Path("cloudconnectsettings")
  [XmlRoot("results")]
  public class CloudConnectorList : BaseApiListBean<CloudConnector> {
    [XmlElement("CloudConnectSettingss")]
    [XmlElement("CloudConnectSettings")]
   
    public override List<CloudConnector>? GetItems() => items;

    public override void SetItems(List<CloudConnector>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CloudConnector>? items)
    {
        this.items = items;
    }
  }
}

}