using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("systemattribute")
[XmlRoot("systemAttribute")]
public class SystemAttribute : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;
  private Object value;
  private string? valueString;

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

  public Object Value
  {
      get => value;
      set => value = value;
  }

  public string? ValueString
  {
      get => valueString;
      set => valueString = value;
  }

  // Path("systemattribute")
  [XmlRoot("results")]
  public class SystemAttributeList : BaseApiListBean<SystemAttribute> {    public override List<SystemAttribute>? GetItems() => items;

    public override void SetItems(List<SystemAttribute>? value) => items = value;

  }
}

}