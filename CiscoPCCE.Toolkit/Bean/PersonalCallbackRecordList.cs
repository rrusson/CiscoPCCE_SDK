using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("personalcallback")
[XmlRoot("results")]
public class PersonalCallbackRecordList : BaseApiBean {
  private List<PersonalCallbackRecord>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("personalCallbacks")]
  [XmlElement("personalCallback")]
  public List<PersonalCallbackRecord>? Items
  {
      get => items;
      set => items = value;
  }

  public PageInfo PageInfo
  {
      get => pageInfo;
      set => pageInfo = value;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("personalcallback")
  [XmlRoot("results")]
  public class PersonalCallbackRecordListList : BaseApiListBean<PersonalCallbackRecordList> {    public override List<PersonalCallbackRecordList>? GetItems() => items;

    public override void SetItems(List<PersonalCallbackRecordList>? value) => items = value;

  }
}

}