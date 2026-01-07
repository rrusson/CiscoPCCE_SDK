using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("pqName")]
public class PQName : BaseApiBean {
  private string? enterpriseName;
  private int? pqID;
  private string? pqURL;

  public string? EnterpriseName
  {
      get => enterpriseName;
      set => enterpriseName = value;
  }


  public void setEnterpriseName(String enterpriseName) {
     this.enterpriseName = enterpriseName;
  }

  public int? pqID
  {
      get => pqID;
      set => pqID = value;
  }


  public void setpqID(int? pqID) {
     this.pqID = pqID;
  }

  public string? pqURL
  {
      get => pqURL;
      set => pqURL = value;
  }


  public void setpqURL(String pqURL) {
     this.pqURL = pqURL;
  }


}

}