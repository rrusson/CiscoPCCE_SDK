using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class Operation : BaseApiBean {
  private ChangeSet changeSet;
  private OperationType operationType;
  private List<string?>? refUrls;

  public ChangeSet ChangeSet
  {
      get => changeSet;
      set => changeSet = value;
  }


  public void setChangeSet(ChangeSet changeSet) {
     this.changeSet = changeSet;
  }

  public OperationType OperationType
  {
      get => operationType;
      set => operationType = value;
  }


  public void setOperationType(OperationType operationType) {
     this.operationType = operationType;
  }

  [XmlElement("refURLs")]
  [XmlElement("refURL")]
  public List<string?>? RefUrls
  {
      get => refUrls;
      set => refUrls = value;
  }


  public void setRefUrls(List<String> refUrls) {
     this.refUrls = refUrls;
  }


}

}