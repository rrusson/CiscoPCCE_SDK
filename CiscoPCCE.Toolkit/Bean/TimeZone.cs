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


  public void setBias(int? bias) {
     this.bias = bias;
  }

  [XmlElement("displayName")]
  public string? DisplayName
  {
      get => displayName;
      set => displayName = value;
  }


  public void setDisplayName(String displayName) {
     this.displayName = displayName;
  }

  [XmlElement("dstName")]
  public string? DstName
  {
      get => dstName;
      set => dstName = value;
  }


  public void setDstName(String dstName) {
     this.dstName = dstName;
  }

  [XmlElement("dstObserved")]
  public bool? DstObserved
  {
      get => dstObserved;
      set => dstObserved = value;
  }


  public void setDstObserved(bool? dstObserved) {
     this.dstObserved = dstObserved;
  }

  [XmlElement("name")]
  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  [XmlElement("refURL")]
  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  [XmlElement("stdName")]
  public string? StdName
  {
      get => stdName;
      set => stdName = value;
  }


  public void setStdName(String stdName) {
     this.stdName = stdName;
  }


  // Path("timezone")
  [XmlRoot("results")]
  public class TimeZoneList : BaseApiListBean<TimeZone> {
    [XmlElement("timeZones")]
    [XmlElement("timeZone")]
   
    public override List<TimeZone>? GetItems() => items;

    public override void SetItems(List<TimeZone>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<TimeZone>? items)
    {
        this.items = items;
    }
  }
}

}