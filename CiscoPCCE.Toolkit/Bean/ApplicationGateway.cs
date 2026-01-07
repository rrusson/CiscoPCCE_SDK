using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("applicationgateway")
[XmlRoot("applicationGateway")]
public class ApplicationGateway : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private List<ApplicationGatewayConnection>? connections;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private ApplicationGatewayEncryptionEnum encryption;
  private ApplicationGatewayFaultTolerance faultTolerance;
  private string? idFromRefUrl;
  private string? name;
  private ApplicationGatewayPreferredSide preferredSide;
  private string? refURL;

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

  [XmlElement("connections")]
  [XmlElement("connection")]
  public List<ApplicationGatewayConnection>? Connections
  {
      get => connections;
      set => connections = value;
  }


  public void setConnections(List<ApplicationGatewayConnection> connections) {
     this.connections = connections;
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

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public ApplicationGatewayEncryptionEnum Encryption
  {
      get => encryption;
      set => encryption = value;
  }


  public void setEncryption(ApplicationGatewayEncryptionEnum encryption) {
     this.encryption = encryption;
  }

  public ApplicationGatewayFaultTolerance FaultTolerance
  {
      get => faultTolerance;
      set => faultTolerance = value;
  }


  public void setFaultTolerance(ApplicationGatewayFaultTolerance faultTolerance) {
     this.faultTolerance = faultTolerance;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public ApplicationGatewayPreferredSide PreferredSide
  {
      get => preferredSide;
      set => preferredSide = value;
  }


  public void setPreferredSide(ApplicationGatewayPreferredSide preferredSide) {
     this.preferredSide = preferredSide;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("applicationgateway")
  [XmlRoot("results")]
  public class ApplicationGatewayList : BaseApiListBean<ApplicationGateway> {
    [XmlElement("applicationGateways")]
    [XmlElement("applicationGateway")]
   
    public override List<ApplicationGateway>? GetItems() => items;

    public override void SetItems(List<ApplicationGateway>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ApplicationGateway>? items)
    {
        this.items = items;
    }
  }
}

}