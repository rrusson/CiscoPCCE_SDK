using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("location")
[XmlRoot("location")]
public class Location : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private string? cucmHostAddress;
  private List<ReferenceBean>? datacenters;
  private ReferenceBean department;
  private string? description;
  private List<ReferenceBean>? gateways;
  private string? idFromRefUrl;
  private string? locationCode;
  private string? locationName;
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

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public string? CucmHostAddress
  {
      get => cucmHostAddress;
      set => cucmHostAddress = value;
  }

  [XmlElement("datacenters")]
  [XmlElement("datacenter")]
  public List<ReferenceBean>? Datacenters
  {
      get => datacenters;
      set => datacenters = value;
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

  [XmlElement("gateways")]
  [XmlElement("gateway")]
  public List<ReferenceBean>? Gateways
  {
      get => gateways;
      set => gateways = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? LocationCode
  {
      get => locationCode;
      set => locationCode = value;
  }

  public string? LocationName
  {
      get => locationName;
      set => locationName = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("location")
  [XmlRoot("results")]
  public class LocationList : BaseApiListBean<Location> {    public override List<Location>? GetItems() => items;

    public override void SetItems(List<Location>? value) => items = value;

  }
}

}