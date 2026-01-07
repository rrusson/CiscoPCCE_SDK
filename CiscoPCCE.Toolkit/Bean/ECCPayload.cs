using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("/eccpayload")
[XmlRoot("eccpayload")]
public class ECCPayload : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;
  private List<ReferenceBean>? variables;

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

  public string? Description
  {
      get => description;
      set => description = value;
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

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  [XmlElement("variables")]
  [XmlElement("variable")]
  public List<ReferenceBean>? Variables
  {
      get => variables;
      set => variables = value;
  }

  // Path("/eccpayload")
  [XmlRoot("results")]
  public class ECCPayloadList : BaseApiListBean<ECCPayload> {    public override List<ECCPayload>? GetItems() => items;

    public override void SetItems(List<ECCPayload>? value) => items = value;

  }
}

}