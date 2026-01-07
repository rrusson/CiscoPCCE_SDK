using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class AssociatedGroup : BaseApiBean {
  private string? groupName;
  private string? id;

  public string? GroupName
  {
      get => groupName;
      set => groupName = value;
  }


  public void setGroupName(String groupName) {
     this.groupName = groupName;
  }

  public string? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(String id) {
     this.id = id;
  }


}

}