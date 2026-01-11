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


public class Session extends BaseApiBean {
  private Integer openTimeout;
  private Integer retryLimit;
  private Integer retryTimeout;

  public Integer getOpenTimeout() {
     return this.openTimeout;
  }

  public void setOpenTimeout(Integer openTimeout) {
     this.openTimeout = openTimeout;
  }

  public Integer getRetryLimit() {
     return this.retryLimit;
  }

  public void setRetryLimit(Integer retryLimit) {
     this.retryLimit = retryLimit;
  }

  public Integer getRetryTimeout() {
     return this.retryTimeout;
  }

  public void setRetryTimeout(Integer retryTimeout) {
     this.retryTimeout = retryTimeout;
  }


}
