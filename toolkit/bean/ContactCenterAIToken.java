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


@Path("contactcenterai/token")
@XmlRootElement(name="contactCenterAIToken")
public class ContactCenterAIToken extends BaseApiBean {
  private String accessToken;
  private String cmsUrl;
  private String expiresIn;
  private String orgId;
  private String u2cHost;

  public String getAccessToken() {
     return this.accessToken;
  }

  public void setAccessToken(String accessToken) {
     this.accessToken = accessToken;
  }

  public String getCmsUrl() {
     return this.cmsUrl;
  }

  public void setCmsUrl(String cmsUrl) {
     this.cmsUrl = cmsUrl;
  }

  public String getExpiresIn() {
     return this.expiresIn;
  }

  public void setExpiresIn(String expiresIn) {
     this.expiresIn = expiresIn;
  }

  public String getOrgId() {
     return this.orgId;
  }

  public void setOrgId(String orgId) {
     this.orgId = orgId;
  }

  public String getU2cHost() {
     return this.u2cHost;
  }

  public void setU2cHost(String u2cHost) {
     this.u2cHost = u2cHost;
  }


  @Path("contactcenterai/token")
  @XmlRootElement(name = "results")
  public static class ContactCenterAITokenList extends BaseApiListBean<ContactCenterAIToken> {
    @XmlElementWrapper(name = "contactCenterAITokens")
    @XmlElement(name = "contactCenterAIToken")
    public List<ContactCenterAIToken> getItems() {
      return items;
    }

    public void setItems(List<ContactCenterAIToken> items) {
      this.items = items;
    }
  }
}
