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


@XmlRootElement(name="courtesyCallBack")
public class CourtesyCallBack extends BaseApiBean {
  private String allowUnmatchedDialedNumbers;
  private List<String> allowedDialedNumbers;
  private List<String> deniedDialedNumbers;
  private String maximumCallBacksPerAni;
  private String reportingAddress;

  public String getAllowUnmatchedDialedNumbers() {
     return this.allowUnmatchedDialedNumbers;
  }

  public void setAllowUnmatchedDialedNumbers(String allowUnmatchedDialedNumbers) {
     this.allowUnmatchedDialedNumbers = allowUnmatchedDialedNumbers;
  }

  public List<String> getAllowedDialedNumbers() {
     return this.allowedDialedNumbers;
  }

  public void setAllowedDialedNumbers(List<String> allowedDialedNumbers) {
     this.allowedDialedNumbers = allowedDialedNumbers;
  }

  public List<String> getDeniedDialedNumbers() {
     return this.deniedDialedNumbers;
  }

  public void setDeniedDialedNumbers(List<String> deniedDialedNumbers) {
     this.deniedDialedNumbers = deniedDialedNumbers;
  }

  public String getMaximumCallBacksPerAni() {
     return this.maximumCallBacksPerAni;
  }

  public void setMaximumCallBacksPerAni(String maximumCallBacksPerAni) {
     this.maximumCallBacksPerAni = maximumCallBacksPerAni;
  }

  public String getReportingAddress() {
     return this.reportingAddress;
  }

  public void setReportingAddress(String reportingAddress) {
     this.reportingAddress = reportingAddress;
  }


}
