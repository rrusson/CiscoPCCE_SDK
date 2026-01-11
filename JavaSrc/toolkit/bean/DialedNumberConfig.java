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


@XmlRootElement(name="dialedNumberConfig")
public class DialedNumberConfig extends BaseApiBean {
  private String dialedNumber;
  private String postCallSurveyNumber;
  private String ringtone;

  public String getDialedNumber() {
     return this.dialedNumber;
  }

  public void setDialedNumber(String dialedNumber) {
     this.dialedNumber = dialedNumber;
  }

  public String getPostCallSurveyNumber() {
     return this.postCallSurveyNumber;
  }

  public void setPostCallSurveyNumber(String postCallSurveyNumber) {
     this.postCallSurveyNumber = postCallSurveyNumber;
  }

  public String getRingtone() {
     return this.ringtone;
  }

  public void setRingtone(String ringtone) {
     this.ringtone = ringtone;
  }


}
