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

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? DeploymentID
  {
      get => deploymentID;
      set => deploymentID = value;
  }

  public string? DeploymentName
  {
      get => deploymentName;
      set => deploymentName = value;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? ProxyAddress
  {
      get => proxyAddress;
      set => proxyAddress = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public string? RegistrationStatus
  {
      get => registrationStatus;
      set => registrationStatus = value;
  }

  // Path("cloudconnectsettings")
  [XmlRoot("results")]
  public class CloudConnectorList : BaseApiListBean<CloudConnector> {    public override List<CloudConnector>? GetItems() => items;

    public override void SetItems(List<CloudConnector>? value) => items = value;

  }
}

}