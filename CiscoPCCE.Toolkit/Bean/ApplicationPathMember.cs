using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("applicationpath")
[XmlRoot("applicationPathMember")]
public class ApplicationPathMember : BaseApiBean {
  private int? applicationPathId;
  private int? mrDomainId;
  private short? peripheralId;

  public int? ApplicationPathId
  {
      get => applicationPathId;
      set => applicationPathId = value;
  }

  public int? MrDomainId
  {
      get => mrDomainId;
      set => mrDomainId = value;
  }

  public short? PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }

  // Path("applicationpath")
  [XmlRoot("results")]
  public class ApplicationPathMemberList : BaseApiListBean<ApplicationPathMember> {    public override List<ApplicationPathMember>? GetItems() => items;

    public override void SetItems(List<ApplicationPathMember>? value) => items = value;

  }
}

}