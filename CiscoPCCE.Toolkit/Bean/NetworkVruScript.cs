using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("networkvruscript")
[XmlRoot("networkVruScript")]
public class NetworkVruScript : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? configParam;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? interruptible;
  private string? name;
  private string? refURL;
  private int? routingType;
  private int? timeout;
  private string? vruScriptName;

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

  public string? ConfigParam
  {
      get => configParam;
      set => configParam = value;
  }


  public void setConfigParam(String configParam) {
     this.configParam = configParam;
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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? Interruptible
  {
      get => interruptible;
      set => interruptible = value;
  }


  public void setInterruptible(Boolean interruptible) {
     this.interruptible = interruptible;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? RoutingType
  {
      get => routingType;
      set => routingType = value;
  }


  public void setRoutingType(int? routingType) {
     this.routingType = routingType;
  }

  public int? Timeout
  {
      get => timeout;
      set => timeout = value;
  }


  public void setTimeout(int? timeout) {
     this.timeout = timeout;
  }

  public string? VruScriptName
  {
      get => vruScriptName;
      set => vruScriptName = value;
  }


  public void setVruScriptName(String vruScriptName) {
     this.vruScriptName = vruScriptName;
  }


  // Path("networkvruscript")
  [XmlRoot("results")]
  public class NetworkVruScriptList : BaseApiListBean<NetworkVruScript> {
    [XmlElement("networkVruScripts")]
    [XmlElement("networkVruScript")]
   
    public override List<NetworkVruScript>? GetItems() => items;

    public override void SetItems(List<NetworkVruScript>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<NetworkVruScript>? items)
    {
        this.items = items;
    }
  }
}

}