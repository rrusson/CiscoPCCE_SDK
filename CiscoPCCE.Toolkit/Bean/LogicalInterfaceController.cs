using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("globalsetting")
[XmlRoot("pg")]
public class LogicalInterfaceController : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private Short clientType;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private Short logicalControllerType;
  private bool? markDeletable;
  private string? name;
  private string? primaryCtiAddress;
  private string? refURL;
  private string? secondaryCtiAddress;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public Short ClientType
  {
      get => clientType;
      set => clientType = value;
  }


  public void setClientType(Short clientType) {
     this.clientType = clientType;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public Short LogicalControllerType
  {
      get => logicalControllerType;
      set => logicalControllerType = value;
  }


  public void setLogicalControllerType(Short logicalControllerType) {
     this.logicalControllerType = logicalControllerType;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? PrimaryCtiAddress
  {
      get => primaryCtiAddress;
      set => primaryCtiAddress = value;
  }


  public void setPrimaryCtiAddress(String primaryCtiAddress) {
     this.primaryCtiAddress = primaryCtiAddress;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? SecondaryCtiAddress
  {
      get => secondaryCtiAddress;
      set => secondaryCtiAddress = value;
  }


  public void setSecondaryCtiAddress(String secondaryCtiAddress) {
     this.secondaryCtiAddress = secondaryCtiAddress;
  }


  // Path("globalsetting")
  [XmlRoot("results")]
  public class LogicalInterfaceControllerList : BaseApiListBean<LogicalInterfaceController> {
    [XmlElement("pgs")]
    [XmlElement("pg")]
   
    public override List<LogicalInterfaceController>? GetItems() => items;

    public override void SetItems(List<LogicalInterfaceController>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<LogicalInterfaceController>? items)
    {
        this.items = items;
    }
  }
}

}