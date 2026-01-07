using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("precisionqueue")
[XmlRoot("results")]
public class PrecisionQueueList : BaseApiBean {
  private List<PrecisionQueue>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("precisionQueues")]
  [XmlElement("precisionQueue")]
  public List<PrecisionQueue>? Items
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

  // Path("precisionqueue")
  [XmlRoot("results")]
  public class PrecisionQueueListList : BaseApiListBean<PrecisionQueueList> {    public override List<PrecisionQueueList>? GetItems() => items;

    public override void SetItems(List<PrecisionQueueList>? value) => items = value;

  }
}

}