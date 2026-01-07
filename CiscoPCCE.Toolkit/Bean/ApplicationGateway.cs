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

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  [XmlElement("connections")]
  [XmlElement("connection")]
  public List<ApplicationGatewayConnection>? Connections
  {
      get => connections;
      set => connections = value;
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

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public ApplicationGatewayEncryptionEnum Encryption
  {
      get => encryption;
      set => encryption = value;
  }

  public ApplicationGatewayFaultTolerance FaultTolerance
  {
      get => faultTolerance;
      set => faultTolerance = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public ApplicationGatewayPreferredSide PreferredSide
  {
      get => preferredSide;
      set => preferredSide = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("applicationgateway")
  [XmlRoot("results")]
  public class ApplicationGatewayList : BaseApiListBean<ApplicationGateway> {    public override List<ApplicationGateway>? GetItems() => items;

    public override void SetItems(List<ApplicationGateway>? value) => items = value;

  }
}

}