using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("AgentPQCount")]
public class AgentPQCount : BaseApiBean {
  private string? refURL;
  private int? pqCount;
  private List<PQName>? pqNameList;

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? pqCount
  {
      get => pqCount;
      set => pqCount = value;
  }


  public void setpqCount(int? pqCount) {
     this.pqCount = pqCount;
  }

  [XmlElement("pqNameList")]
  [XmlElement("pqName")]
  public List<PQName>? pqNameList
  {
      get => pqNameList;
      set => pqNameList = value;
  }


  public void setpqNameList(List<PQName> pqNameList) {
     this.pqNameList = pqNameList;
  }


}

}