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


public class Media extends BaseApiBean {
  private String codec;
  private String mrcpVersion;
  private Boolean overrideSystemPrompt;

  public String getCodec() {
     return this.codec;
  }

  public void setCodec(String codec) {
     this.codec = codec;
  }

  public String getMrcpVersion() {
     return this.mrcpVersion;
  }

  public void setMrcpVersion(String mrcpVersion) {
     this.mrcpVersion = mrcpVersion;
  }

  public Boolean getOverrideSystemPrompt() {
     return this.overrideSystemPrompt;
  }

  public void setOverrideSystemPrompt(Boolean overrideSystemPrompt) {
     this.overrideSystemPrompt = overrideSystemPrompt;
  }


}
