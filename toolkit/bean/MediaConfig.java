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


@XmlRootElement(name="media")
public class MediaConfig extends BaseApiBean {
  private String codec;
  private String mRCPVersion;
  private Boolean overrideSystemPrompt;

  public String getCodec() {
     return this.codec;
  }

  public void setCodec(String codec) {
     this.codec = codec;
  }

  public String getMRCPVersion() {
     return this.mRCPVersion;
  }

  public void setMRCPVersion(String mRCPVersion) {
     this.mRCPVersion = mRCPVersion;
  }

  public Boolean getOverrideSystemPrompt() {
     return this.overrideSystemPrompt;
  }

  public void setOverrideSystemPrompt(Boolean overrideSystemPrompt) {
     this.overrideSystemPrompt = overrideSystemPrompt;
  }


}
