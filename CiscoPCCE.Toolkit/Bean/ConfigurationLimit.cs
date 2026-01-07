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

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public int? ConfigLimitCurrentValue
  {
      get => configLimitCurrentValue;
      set => configLimitCurrentValue = value;
  }

  public int? ConfigLimitDefaultValue
  {
      get => configLimitDefaultValue;
      set => configLimitDefaultValue = value;
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

  // Path("configurationlimit")
  [XmlRoot("results")]
  public class ConfigurationLimitList : BaseApiListBean<ConfigurationLimit> {    public override List<ConfigurationLimit>? GetItems() => items;

    public override void SetItems(List<ConfigurationLimit>? value) => items = value;

  }
}

}