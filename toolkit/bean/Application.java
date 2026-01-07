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


@XmlRootElement(name="application")
public class Application extends BaseApiBean {
  private String applicationName;
  private String description;
  private String enabled;
  private ICMPostRouting iCMPostRouting;
  private ICMTranslationRouting iCMTranslationRouting;
  private Integer id;
  private int maxsession;
  private ScriptApplication scriptApplication;
  private String self;
  private String type;

  public String getApplicationName() {
     return this.applicationName;
  }

  public void setApplicationName(String applicationName) {
     this.applicationName = applicationName;
  }

  public String getDescription() {
     return this.description;
  }

  public void setDescription(String description) {
     this.description = description;
  }

  public String getEnabled() {
     return this.enabled;
  }

  public void setEnabled(String enabled) {
     this.enabled = enabled;
  }

  public ICMPostRouting getICMPostRouting() {
     return this.iCMPostRouting;
  }

  public void setICMPostRouting(ICMPostRouting iCMPostRouting) {
     this.iCMPostRouting = iCMPostRouting;
  }

  public ICMTranslationRouting getICMTranslationRouting() {
     return this.iCMTranslationRouting;
  }

  public void setICMTranslationRouting(ICMTranslationRouting iCMTranslationRouting) {
     this.iCMTranslationRouting = iCMTranslationRouting;
  }

  public Integer getId() {
     return this.id;
  }

  public void setId(Integer id) {
     this.id = id;
  }

  public int getMaxsession() {
     return this.maxsession;
  }

  public void setMaxsession(int maxsession) {
     this.maxsession = maxsession;
  }

  public ScriptApplication getScriptApplication() {
     return this.scriptApplication;
  }

  public void setScriptApplication(ScriptApplication scriptApplication) {
     this.scriptApplication = scriptApplication;
  }

  public String getSelf() {
     return this.self;
  }

  public void setSelf(String self) {
     this.self = self;
  }

  public String getType() {
     return this.type;
  }

  public void setType(String type) {
     this.type = type;
  }


}
