using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("configurationlimit")
[XmlRoot("configurationLimit")]
public class ConfigurationLimit : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private int? configLimitCurrentValue;
  private int? configLimitDefaultValue;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private string? name;
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

  public int? ConfigLimitCurrentValue
  {
      get => configLimitCurrentValue;
      set => configLimitCurrentValue = value;
  }


  public void setConfigLimitCurrentValue(int? configLimitCurrentValue) {
     this.configLimitCurrentValue = configLimitCurrentValue;
  }

  public int? ConfigLimitDefaultValue
  {
      get => configLimitDefaultValue;
      set => configLimitDefaultValue = value;
  }


  public void setConfigLimitDefaultValue(int? configLimitDefaultValue) {
     this.configLimitDefaultValue = configLimitDefaultValue;
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


  // Path("configurationlimit")
  [XmlRoot("results")]
  public class ConfigurationLimitList : BaseApiListBean<ConfigurationLimit> {
    [XmlElement("configurationLimits")]
    [XmlElement("configurationLimit")]
   
    public override List<ConfigurationLimit>? GetItems() => items;

    public override void SetItems(List<ConfigurationLimit>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ConfigurationLimit>? items)
    {
        this.items = items;
    }
  }
}

}