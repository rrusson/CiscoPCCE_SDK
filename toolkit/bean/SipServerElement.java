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


@Path("sipservergroup")
@XmlRootElement(name="element")
public class SipServerElement extends BaseApiBean {
  private String address;
  private ReferenceBean dataCenter;
  private String port;
  private String priority;
  private String refURL;
  private String securePort;
  private String weight;

  public String getAddress() {
     return this.address;
  }

  public void setAddress(String address) {
     this.address = address;
  }

  public ReferenceBean getDataCenter() {
     return this.dataCenter;
  }

  public void setDataCenter(ReferenceBean dataCenter) {
     this.dataCenter = dataCenter;
  }

  public String getPort() {
     return this.port;
  }

  public void setPort(String port) {
     this.port = port;
  }

  public String getPriority() {
     return this.priority;
  }

  public void setPriority(String priority) {
     this.priority = priority;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public String getSecurePort() {
     return this.securePort;
  }

  public void setSecurePort(String securePort) {
     this.securePort = securePort;
  }

  public String getWeight() {
     return this.weight;
  }

  public void setWeight(String weight) {
     this.weight = weight;
  }


  @Path("sipservergroup")
  @XmlRootElement(name = "results")
  public static class SipServerElementList extends BaseApiListBean<SipServerElement> {
    @XmlElementWrapper(name = "elements")
    @XmlElement(name = "element")
    public List<SipServerElement> getItems() {
      return items;
    }

    public void setItems(List<SipServerElement> items) {
      this.items = items;
    }
  }
}
