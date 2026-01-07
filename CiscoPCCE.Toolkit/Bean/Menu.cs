using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("menu")]
public class Menu : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private ReferenceBean card;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private List<Feature>? features;
  private bool? hidden;
  private string? idFromRefUrl;
  private string? name;
  private string? path;
  private string? refURL;
  private bool? systemDefined;
  private string? uniqueId;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ReferenceBean Card
  {
      get => card;
      set => card = value;
  }


  public void setCard(ReferenceBean card) {
     this.card = card;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
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

  [XmlElement("features")]
  [XmlElement("feature")]
  public List<Feature>? Features
  {
      get => features;
      set => features = value;
  }


  public void setFeatures(List<Feature> features) {
     this.features = features;
  }

  public bool? Hidden
  {
      get => hidden;
      set => hidden = value;
  }


  public void setHidden(bool? hidden) {
     this.hidden = hidden;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? Path
  {
      get => path;
      set => path = value;
  }


  public void setPath(String path) {
     this.path = path;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public bool? SystemDefined
  {
      get => systemDefined;
      set => systemDefined = value;
  }


  public void setSystemDefined(bool? systemDefined) {
     this.systemDefined = systemDefined;
  }

  public string? UniqueId
  {
      get => uniqueId;
      set => uniqueId = value;
  }


  public void setUniqueId(String uniqueId) {
     this.uniqueId = uniqueId;
  }


}

}