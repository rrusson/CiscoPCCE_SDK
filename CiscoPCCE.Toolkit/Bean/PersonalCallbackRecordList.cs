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


  public void setPageInfo(PageInfo pageInfo) {
     this.pageInfo = pageInfo;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }


  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }


  // Path("personalcallback")
  [XmlRoot("results")]
  public class PersonalCallbackRecordListList : BaseApiListBean<PersonalCallbackRecordList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<PersonalCallbackRecordList>? GetItems() => items;

    public override void SetItems(List<PersonalCallbackRecordList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PersonalCallbackRecordList>? items)
    {
        this.items = items;
    }
  }
}

}