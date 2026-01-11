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


@XmlRootElement(name="routePatternConfigs")
public class RoutePatternConfig extends BaseApiBean {
  private String destinationHostOrIP;
  private boolean enableSendCallsToOriginator;
  private int rnaTimeoutInSeconds;
  private String routePattern;

  public String getDestinationHostOrIP() {
     return this.destinationHostOrIP;
  }

  public void setDestinationHostOrIP(String destinationHostOrIP) {
     this.destinationHostOrIP = destinationHostOrIP;
  }

  public boolean getEnableSendCallsToOriginator() {
     return this.enableSendCallsToOriginator;
  }

  public void setEnableSendCallsToOriginator(boolean enableSendCallsToOriginator) {
     this.enableSendCallsToOriginator = enableSendCallsToOriginator;
  }

  public int getRnaTimeoutInSeconds() {
     return this.rnaTimeoutInSeconds;
  }

  public void setRnaTimeoutInSeconds(int rnaTimeoutInSeconds) {
     this.rnaTimeoutInSeconds = rnaTimeoutInSeconds;
  }

  public String getRoutePattern() {
     return this.routePattern;
  }

  public void setRoutePattern(String routePattern) {
     this.routePattern = routePattern;
  }


}
