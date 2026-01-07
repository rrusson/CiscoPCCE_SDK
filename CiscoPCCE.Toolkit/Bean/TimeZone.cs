using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("timezone")
[XmlRoot("timeZone")]
public class TimeZone : BaseApiBean {
  private int? bias;
  private string? displayName;
  private string? dstName;
  private bool? dstObserved;
  private string? name;
  private string? refURL;
  private string? stdName;

  [XmlElement("bias")]
  public int? Bias
  {
      get => bias;
      set => bias = value;
  }

  [XmlElement("displayName")]
  public string? DisplayName
  {
      get => displayName;
      set => displayName = value;
  }

  [XmlElement("dstName")]
  public string? DstName
  {
      get => dstName;
      set => dstName = value;
  }

  [XmlElement("dstObserved")]
  public bool? DstObserved
  {
      get => dstObserved;
      set => dstObserved = value;
  }

  [XmlElement("name")]
  public string? Name
  {
      get => name;
      set => name = value;
  }

  [XmlElement("refURL")]
  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  [XmlElement("stdName")]
  public string? StdName
  {
      get => stdName;
      set => stdName = value;
  }

  // Path("timezone")
  [XmlRoot("results")]
  public class TimeZoneList : BaseApiListBean<TimeZone> {    public override List<TimeZone>? GetItems() => items;

    public override void SetItems(List<TimeZone>? value) => items = value;

  }
}

}