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


public class HeartBeat extends BaseApiBean {
  private Integer interval;
  private Integer requestTimeout;
  private Integer retryLimit;
  private Integer retryTimeout;

  public Integer getInterval() {
     return this.interval;
  }

  public void setInterval(Integer interval) {
     this.interval = interval;
  }

  public Integer getRequestTimeout() {
     return this.requestTimeout;
  }

  public void setRequestTimeout(Integer requestTimeout) {
     this.requestTimeout = requestTimeout;
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
