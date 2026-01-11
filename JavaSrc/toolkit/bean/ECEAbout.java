// ----------------------------------------------
package com.cisco.ccbu.cce.unifiedconfig.toolkit.bean;

import com.cisco.ccbu.cce.unifiedconfig.toolkit.BaseApiBean;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.ws.rs.Path;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.List;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.ReferenceBean;
import java.util.Date;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.BaseApiListBean;

import javax.xml.bind.annotation.XmlElement;

import javax.xml.bind.annotation.XmlElementWrapper;


@XmlRootElement(name="about")
public class ECEAbout extends BaseApiBean {
  private String contact;
  private String copyrights;
  private List<ECEProduct> products;
  private String trademarks;

  public String getContact() {
     return this.contact;
  }

  public void setContact(String contact) {
     this.contact = contact;
  }

  public String getCopyrights() {
     return this.copyrights;
  }

  public void setCopyrights(String copyrights) {
     this.copyrights = copyrights;
  }

  @XmlElementWrapper(name="products")
  @XmlElement(name="product")
  public List<ECEProduct> getProducts() {
     return this.products;
  }

  public void setProducts(List<ECEProduct> products) {
     this.products = products;
  }

  public String getTrademarks() {
     return this.trademarks;
  }

  public void setTrademarks(String trademarks) {
     this.trademarks = trademarks;
  }


}
