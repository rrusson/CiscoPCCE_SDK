using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("expandedcallvariable")
[XmlRoot("expandedCallVariable")]
public class ExpandedCallVariable : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? bytesRequired;
  private int? bytesRequiredInCtiServer;
  private int? changeStamp;
  private bool? ciscoProvided;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private bool? eccArray;
  private bool? enabled;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private int? maximumArraySize;
  private int? maximumLength;
  private string? name;
  private bool? persistent;
  private string? refURL;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? BytesRequired
  {
      get => bytesRequired;
      set => bytesRequired = value;
  }


  public void setBytesRequired(int? bytesRequired) {
     this.bytesRequired = bytesRequired;
  }

  public int? BytesRequiredInCtiServer
  {
      get => bytesRequiredInCtiServer;
      set => bytesRequiredInCtiServer = value;
  }


  public void setBytesRequiredInCtiServer(int? bytesRequiredInCtiServer) {
     this.bytesRequiredInCtiServer = bytesRequiredInCtiServer;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public bool? CiscoProvided
  {
      get => ciscoProvided;
      set => ciscoProvided = value;
  }


  public void setCiscoProvided(Boolean ciscoProvided) {
     this.ciscoProvided = ciscoProvided;
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

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public bool? EccArray
  {
      get => eccArray;
      set => eccArray = value;
  }


  public void setEccArray(Boolean eccArray) {
     this.eccArray = eccArray;
  }

  public bool? Enabled
  {
      get => enabled;
      set => enabled = value;
  }


  public void setEnabled(Boolean enabled) {
     this.enabled = enabled;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public int? MaximumArraySize
  {
      get => maximumArraySize;
      set => maximumArraySize = value;
  }


  public void setMaximumArraySize(int? maximumArraySize) {
     this.maximumArraySize = maximumArraySize;
  }

  public int? MaximumLength
  {
      get => maximumLength;
      set => maximumLength = value;
  }


  public void setMaximumLength(int? maximumLength) {
     this.maximumLength = maximumLength;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public bool? Persistent
  {
      get => persistent;
      set => persistent = value;
  }


  public void setPersistent(Boolean persistent) {
     this.persistent = persistent;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("expandedcallvariable")
  [XmlRoot("results")]
  public class ExpandedCallVariableList : BaseApiListBean<ExpandedCallVariable> {
    [XmlElement("expandedCallVariables")]
    [XmlElement("expandedCallVariable")]
   
    public override List<ExpandedCallVariable>? GetItems() => items;

    public override void SetItems(List<ExpandedCallVariable>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ExpandedCallVariable>? items)
    {
        this.items = items;
    }
  }
}

}