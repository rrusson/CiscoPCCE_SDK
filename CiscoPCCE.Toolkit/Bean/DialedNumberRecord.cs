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


  public void setId(int? id) {
     this.id = id;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }


  // Path("dialednumber")
  [XmlRoot("results")]
  public class DialedNumberRecordList : BaseApiListBean<DialedNumberRecord> {
    [XmlElement("dialedNumberRecords")]
    [XmlElement("dialedNumberRecord")]
   
    public override List<DialedNumberRecord>? GetItems() => items;

    public override void SetItems(List<DialedNumberRecord>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DialedNumberRecord>? items)
    {
        this.items = items;
    }
  }
}

}