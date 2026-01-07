using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("about")]
public class ECEAbout : BaseApiBean {
  private string? contact;
  private string? copyrights;
  private List<ECEProduct>? products;
  private string? trademarks;

  public string? Contact
  {
      get => contact;
      set => contact = value;
  }


  public void setContact(String contact) {
     this.contact = contact;
  }

  public string? Copyrights
  {
      get => copyrights;
      set => copyrights = value;
  }


  public void setCopyrights(String copyrights) {
     this.copyrights = copyrights;
  }

  [XmlElement("products")]
  [XmlElement("product")]
  public List<ECEProduct>? Products
  {
      get => products;
      set => products = value;
  }


  public void setProducts(List<ECEProduct> products) {
     this.products = products;
  }

  public string? Trademarks
  {
      get => trademarks;
      set => trademarks = value;
  }


  public void setTrademarks(String trademarks) {
     this.trademarks = trademarks;
  }


}

}