using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("card")]
public class Card : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? color;
  private string? correlationId;
  private ReferenceBean department;
  private string? header;
  private string? icon;
  private string? idFromRefUrl;
  private List<Menu>? menus;
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

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? Color
  {
      get => color;
      set => color = value;
  }


  public void setColor(String color) {
     this.color = color;
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

  public string? Header
  {
      get => header;
      set => header = value;
  }


  public void setHeader(String header) {
     this.header = header;
  }

  public string? Icon
  {
      get => icon;
      set => icon = value;
  }


  public void setIcon(String icon) {
     this.icon = icon;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public List<Menu>? Menus
  {
      get => menus;
      set => menus = value;
  }


  public void setMenus(List<Menu> menus) {
     this.menus = menus;
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