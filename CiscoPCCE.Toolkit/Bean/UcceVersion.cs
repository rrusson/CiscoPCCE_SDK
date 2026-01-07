using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("ucceVersion")]
public class UcceVersion : BaseApiBean {
  private int buildVersion;
  private int esVersion;
  private int maintenanceVersion;
  private int majorVersion;
  private int minorVersion;
  private int srVersion;

  [XmlElement("buildVersion")]
  public int BuildVersion
  {
      get => buildVersion;
      set => buildVersion = value;
  }


  public void setBuildVersion(int buildVersion) {
     this.buildVersion = buildVersion;
  }

  [XmlElement("esVersion")]
  public int EsVersion
  {
      get => esVersion;
      set => esVersion = value;
  }


  public void setEsVersion(int esVersion) {
     this.esVersion = esVersion;
  }

  [XmlElement("maintenanceVersion")]
  public int MaintenanceVersion
  {
      get => maintenanceVersion;
      set => maintenanceVersion = value;
  }


  public void setMaintenanceVersion(int maintenanceVersion) {
     this.maintenanceVersion = maintenanceVersion;
  }

  [XmlElement("majorVersion")]
  public int MajorVersion
  {
      get => majorVersion;
      set => majorVersion = value;
  }


  public void setMajorVersion(int majorVersion) {
     this.majorVersion = majorVersion;
  }

  [XmlElement("minorVersion")]
  public int MinorVersion
  {
      get => minorVersion;
      set => minorVersion = value;
  }


  public void setMinorVersion(int minorVersion) {
     this.minorVersion = minorVersion;
  }

  [XmlElement("srVersion")]
  public int SrVersion
  {
      get => srVersion;
      set => srVersion = value;
  }


  public void setSrVersion(int srVersion) {
     this.srVersion = srVersion;
  }


}

}