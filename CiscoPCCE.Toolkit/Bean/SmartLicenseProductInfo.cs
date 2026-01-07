using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("smartlicense")
[XmlRoot("smartlicenseproductinfo")]
public class SmartLicenseProductInfo : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private int? privacyEnabled;
  private string? productDescription;
  private string? productDisplayName;
  private int? productEnvironment;
  private string? productTag;
  private string? productVersion;
  private string? refURL;
  private int? smartLicenseProductID;

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

  public int? PrivacyEnabled
  {
      get => privacyEnabled;
      set => privacyEnabled = value;
  }


  public void setPrivacyEnabled(int? privacyEnabled) {
     this.privacyEnabled = privacyEnabled;
  }

  public string? ProductDescription
  {
      get => productDescription;
      set => productDescription = value;
  }


  public void setProductDescription(String productDescription) {
     this.productDescription = productDescription;
  }

  public string? ProductDisplayName
  {
      get => productDisplayName;
      set => productDisplayName = value;
  }


  public void setProductDisplayName(String productDisplayName) {
     this.productDisplayName = productDisplayName;
  }

  public int? ProductEnvironment
  {
      get => productEnvironment;
      set => productEnvironment = value;
  }


  public void setProductEnvironment(int? productEnvironment) {
     this.productEnvironment = productEnvironment;
  }

  public string? ProductTag
  {
      get => productTag;
      set => productTag = value;
  }


  public void setProductTag(String productTag) {
     this.productTag = productTag;
  }

  public string? ProductVersion
  {
      get => productVersion;
      set => productVersion = value;
  }


  public void setProductVersion(String productVersion) {
     this.productVersion = productVersion;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? SmartLicenseProductID
  {
      get => smartLicenseProductID;
      set => smartLicenseProductID = value;
  }


  public void setSmartLicenseProductID(int? smartLicenseProductID) {
     this.smartLicenseProductID = smartLicenseProductID;
  }


  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseProductInfoList : BaseApiListBean<SmartLicenseProductInfo> {
    [XmlElement("smartlicenseproductinfos")]
    [XmlElement("smartlicenseproductinfo")]
   
    public override List<SmartLicenseProductInfo>? GetItems() => items;

    public override void SetItems(List<SmartLicenseProductInfo>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SmartLicenseProductInfo>? items)
    {
        this.items = items;
    }
  }
}

}