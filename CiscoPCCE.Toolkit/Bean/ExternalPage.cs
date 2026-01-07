using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("externalpage")
[XmlRoot("externalpage")]
public class ExternalPage : BaseApiBean {
  private string? baseData;
  private string? baseUrlfromRefUrl;
  private ReferenceBean card;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? dynamicData;
  private int? featureId;
  private bool? gadget;
  private int? id;
  private string? idFromRefUrl;
  private string? ipAddress;
  private ReferenceBean menu;
  private string? name;
  private string? refURL;
  private int? tabPosition;
  private string? url;

  public string? BaseData
  {
      get => baseData;
      set => baseData = value;
  }


  public void setBaseData(String baseData) {
     this.baseData = baseData;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ReferenceBean Card
  {
      get => card;
      set => card = value;
  }


  public void setCard(ReferenceBean card) {
     this.card = card;
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

  public string? DynamicData
  {
      get => dynamicData;
      set => dynamicData = value;
  }


  public void setDynamicData(String dynamicData) {
     this.dynamicData = dynamicData;
  }

  public int? FeatureId
  {
      get => featureId;
      set => featureId = value;
  }


  public void setFeatureId(int? featureId) {
     this.featureId = featureId;
  }

  public bool? Gadget
  {
      get => gadget;
      set => gadget = value;
  }


  public void setGadget(Boolean gadget) {
     this.gadget = gadget;
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

  public string? IpAddress
  {
      get => ipAddress;
      set => ipAddress = value;
  }


  public void setIpAddress(String ipAddress) {
     this.ipAddress = ipAddress;
  }

  public ReferenceBean Menu
  {
      get => menu;
      set => menu = value;
  }


  public void setMenu(ReferenceBean menu) {
     this.menu = menu;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? TabPosition
  {
      get => tabPosition;
      set => tabPosition = value;
  }


  public void setTabPosition(int? tabPosition) {
     this.tabPosition = tabPosition;
  }

  public string? Url
  {
      get => url;
      set => url = value;
  }


  public void setUrl(String url) {
     this.url = url;
  }


  // Path("externalpage")
  [XmlRoot("results")]
  public class ExternalPageList : BaseApiListBean<ExternalPage> {
    [XmlElement("externalpages")]
    [XmlElement("externalpage")]
   
    public override List<ExternalPage>? GetItems() => items;

    public override void SetItems(List<ExternalPage>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ExternalPage>? items)
    {
        this.items = items;
    }
  }
}

}