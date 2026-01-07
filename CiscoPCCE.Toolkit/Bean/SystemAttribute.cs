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

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Object Value
  {
      get => value;
      set => value = value;
  }


  public void setValue(Object value) {
     this.value = value;
  }

  public string? ValueString
  {
      get => valueString;
      set => valueString = value;
  }


  public void setValueString(String valueString) {
     this.valueString = valueString;
  }


  // Path("systemattribute")
  [XmlRoot("results")]
  public class SystemAttributeList : BaseApiListBean<SystemAttribute> {
    [XmlElement("systemAttributes")]
    [XmlElement("systemAttribute")]
   
    public override List<SystemAttribute>? GetItems() => items;

    public override void SetItems(List<SystemAttribute>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SystemAttribute>? items)
    {
        this.items = items;
    }
  }
}

}