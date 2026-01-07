using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("ReasonCode")]
public class ReasonCodeConfig : BaseApiBean {
  private bool? active;
  private string? category;
  private string? code;
  private string? forAll;
  private int id;
  private string? label;
  private long? lastmodified;
  private bool? systemCode;
  private string? uri;

  public bool? Active
  {
      get => active;
      set => active = value;
  }


  public void setActive(Boolean active) {
     this.active = active;
  }

  public string? Category
  {
      get => category;
      set => category = value;
  }


  public void setCategory(String category) {
     this.category = category;
  }

  public string? Code
  {
      get => code;
      set => code = value;
  }


  public void setCode(String code) {
     this.code = code;
  }

  public string? ForAll
  {
      get => forAll;
      set => forAll = value;
  }


  public void setForAll(String forAll) {
     this.forAll = forAll;
  }

  public int Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int id) {
     this.id = id;
  }

  public string? Label
  {
      get => label;
      set => label = value;
  }


  public void setLabel(String label) {
     this.label = label;
  }

  public long? Lastmodified
  {
      get => lastmodified;
      set => lastmodified = value;
  }


  public void setLastmodified(long? lastmodified) {
     this.lastmodified = lastmodified;
  }

  public bool? SystemCode
  {
      get => systemCode;
      set => systemCode = value;
  }


  public void setSystemCode(Boolean systemCode) {
     this.systemCode = systemCode;
  }

  public string? Uri
  {
      get => uri;
      set => uri = value;
  }


  public void setUri(String uri) {
     this.uri = uri;
  }


}

}