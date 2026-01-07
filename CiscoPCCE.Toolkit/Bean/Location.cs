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

  public string? CucmHostAddress
  {
      get => cucmHostAddress;
      set => cucmHostAddress = value;
  }


  public void setCucmHostAddress(String cucmHostAddress) {
     this.cucmHostAddress = cucmHostAddress;
  }

  [XmlElement("datacenters")]
  [XmlElement("datacenter")]
  public List<ReferenceBean>? Datacenters
  {
      get => datacenters;
      set => datacenters = value;
  }


  public void setDatacenters(List<ReferenceBean> datacenters) {
     this.datacenters = datacenters;
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

  [XmlElement("gateways")]
  [XmlElement("gateway")]
  public List<ReferenceBean>? Gateways
  {
      get => gateways;
      set => gateways = value;
  }


  public void setGateways(List<ReferenceBean> gateways) {
     this.gateways = gateways;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? LocationCode
  {
      get => locationCode;
      set => locationCode = value;
  }


  public void setLocationCode(String locationCode) {
     this.locationCode = locationCode;
  }

  public string? LocationName
  {
      get => locationName;
      set => locationName = value;
  }


  public void setLocationName(String locationName) {
     this.locationName = locationName;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("location")
  [XmlRoot("results")]
  public class LocationList : BaseApiListBean<Location> {
    [XmlElement("locations")]
    [XmlElement("location")]
   
    public override List<Location>? GetItems() => items;

    public override void SetItems(List<Location>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Location>? items)
    {
        this.items = items;
    }
  }
}

}