using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class ADNameUsedApiErrorDetail : BaseApiBean {
  private string? name;
  private string? refURL;
  private string? referenceType;

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

  public string? ReferenceType
  {
      get => referenceType;
      set => referenceType = value;
  }


  public void setReferenceType(String referenceType) {
     this.referenceType = referenceType;
  }


}

}