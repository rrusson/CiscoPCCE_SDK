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

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public ReferenceBean Card
  {
      get => card;
      set => card = value;
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

  public string? DynamicData
  {
      get => dynamicData;
      set => dynamicData = value;
  }

  public int? FeatureId
  {
      get => featureId;
      set => featureId = value;
  }

  public bool? Gadget
  {
      get => gadget;
      set => gadget = value;
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

  public string? IpAddress
  {
      get => ipAddress;
      set => ipAddress = value;
  }

  public ReferenceBean Menu
  {
      get => menu;
      set => menu = value;
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

  public int? TabPosition
  {
      get => tabPosition;
      set => tabPosition = value;
  }

  public string? Url
  {
      get => url;
      set => url = value;
  }

  // Path("externalpage")
  [XmlRoot("results")]
  public class ExternalPageList : BaseApiListBean<ExternalPage> {    public override List<ExternalPage>? GetItems() => items;

    public override void SetItems(List<ExternalPage>? value) => items = value;

  }
}

}