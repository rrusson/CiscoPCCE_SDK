using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("dialednumber")
[XmlRoot("dialedNumberRecord")]
public class DialedNumberRecord : BaseApiBean {
  private int? id;
  private string? name;

  public int? Id
  {
      get => id;
      set => id = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  // Path("dialednumber")
  [XmlRoot("results")]
  public class DialedNumberRecordList : BaseApiListBean<DialedNumberRecord> {    public override List<DialedNumberRecord>? GetItems() => items;

    public override void SetItems(List<DialedNumberRecord>? value) => items = value;

  }
}

}