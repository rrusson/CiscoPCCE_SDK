using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("applicationpath")
[XmlRoot("applicationPathMember")]
public class ApplicationPathMember : BaseApiBean {
  private int? applicationPathId;
  private int? mrDomainId;
  private Short peripheralId;

  public int? ApplicationPathId
  {
      get => applicationPathId;
      set => applicationPathId = value;
  }


  public void setApplicationPathId(int? applicationPathId) {
     this.applicationPathId = applicationPathId;
  }

  public int? MrDomainId
  {
      get => mrDomainId;
      set => mrDomainId = value;
  }


  public void setMrDomainId(int? mrDomainId) {
     this.mrDomainId = mrDomainId;
  }

  public Short PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }


  public void setPeripheralId(Short peripheralId) {
     this.peripheralId = peripheralId;
  }


  // Path("applicationpath")
  [XmlRoot("results")]
  public class ApplicationPathMemberList : BaseApiListBean<ApplicationPathMember> {
    [XmlElement("applicationPathMembers")]
    [XmlElement("applicationPathMember")]
   
    public override List<ApplicationPathMember>? GetItems() => items;

    public override void SetItems(List<ApplicationPathMember>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ApplicationPathMember>? items)
    {
        this.items = items;
    }
  }
}

}